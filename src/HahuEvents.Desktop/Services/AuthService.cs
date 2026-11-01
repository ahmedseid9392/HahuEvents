
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
                PasswordHash = HashPassword("123"),
                Role = UserRole.Administrator
            },
            new User
            {
                Id = 1,
                FullName = "Nile Business Hub",
                Username = "organizer",
                PasswordHash = HashPassword("123"),
                Role = UserRole.Organizer
            }
        };

        private static int _nextId = 7;
        private static User? _currentUser;

        public static IReadOnlyList<User> GetOrganizers()
        {
            return Users
                .Where(user => user.Role == UserRole.Organizer)
                .OrderBy(user => user.FullName)
                .ToArray();
        }

        public static User? GetOrganizer(int organizerId)
        {
            return Users.FirstOrDefault(user =>
                user.Id == organizerId &&
                user.Role == UserRole.Organizer);
        }

        public static bool SetOrganizerActive(int organizerId, bool isActive)
        {
            User? organizer = GetOrganizer(organizerId);
            if (organizer == null)
            {
                return false;
            }

            organizer.IsActive = isActive;
            return true;
        }

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

            if (string.IsNullOrWhiteSpace(fullName))
            {
                message = "Full name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                message = "Username is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Password is required.";
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
