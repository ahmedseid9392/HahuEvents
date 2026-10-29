
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Services
{
    public static class AuthService
    {
        private const int Iterations = 100_000;
        private const int SaltSize = 16;
        private const int HashSize = 32;

        private static readonly List<User> Users = new()
        {
            new User
            {
                Id = 6,
                FullName = "System Administrator",
                Username = "admin",
                PasswordHash = HashPassword("Admin123!"),
                Role = UserRole.Administrator
            },
            new User
            {
                Id = 1,
                FullName = "Nile Business Hub",
                Username = "organizer",
                PasswordHash = HashPassword("Organizer123!"),
                Role = UserRole.Organizer
            }
        };

        private static int _nextId = 7;
        private static User? _currentUser;

        public static User CurrentUser => _currentUser
            ?? throw new InvalidOperationException("No user is currently logged in.");

        public static bool RegisterOrganizer(
            string fullName,
            string username,
            string password,
            out string message)
        {
            fullName = fullName.Trim();
            username = username.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                message = "All fields are required.";
                return false;
            }

            if (password.Length < 8)
            {
                message = "Password must contain at least 8 characters.";
                return false;
            }

            if (Users.Any(u =>
                u.Username.Equals(
                    username, StringComparison.OrdinalIgnoreCase)))
            {
                message = "This username is already registered.";
                return false;
            }

            Users.Add(new User
            {
                Id = _nextId++,
                FullName = fullName,
                Username = username,
                PasswordHash = HashPassword(password),
                Role = UserRole.Organizer,
                IsActive = true
            });

            message = "Organizer account created successfully.";
            return true;
        }

        public static bool Login(
            string username,
            string password,
            out string message)
        {
            User? user = Users.FirstOrDefault(u =>
                u.Username.Equals(
                    username.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (user == null || !VerifyPassword(
                password, user.PasswordHash))
            {
                message = "Invalid username or password.";
                return false;
            }

            if (!user.IsActive)
            {
                message = "This account is inactive.";
                return false;
            }

            _currentUser = user;
            message = "Login successful.";
            return true;
        }

        public static void Logout()
        {
            _currentUser = null;
        }

        private static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);

            return $"{Iterations}.{Convert.ToBase64String(salt)}." +
                   Convert.ToBase64String(hash);
        }

        private static bool VerifyPassword(
            string password,
            string storedValue)
        {
            try
            {
                string[] parts = storedValue.Split('.');

                int iterations = int.Parse(parts[0]);
                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] expectedHash =
                    Convert.FromBase64String(parts[2]);

                byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    expectedHash.Length);

                return CryptographicOperations.FixedTimeEquals(
                    actualHash, expectedHash);
            }
            catch
            {
                return false;
            }
        }
    }
}
