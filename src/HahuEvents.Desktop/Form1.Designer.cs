
namespace HahuEvents.Desktop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlLogo;
        private Panel pnlEvent;
        private Panel pnlDate;
        private Label lblLogo;
        private Label lblHeading;
        private Label lblWelcome;
        private Label lblDescription;
        private Label lblEvent;
        private Label lblDate;
        private Label lblJune;
        private Label lblLine1;
        private Label lblLine2;
        private Label lblLine3;
        private Label lblSecurity;
        private Label lblSignIn;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnSignIn;
        private Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            pnlLogo = new Panel();
            lblLogo = new Label();
            lblHeading = new Label();
            lblEvent = new Label();
            lblWelcome = new Label();
            lblDescription = new Label();
            pnlEvent = new Panel();
            pnlDate = new Panel();
            lblDate = new Label();
            lblJune = new Label();
            lblLine1 = new Label();
            lblLine2 = new Label();
            lblLine3 = new Label();
            lblSecurity = new Label();
            pnlRight = new Panel();
            lblSignIn = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnSignIn = new Button();
            lblFooter = new Label();
            pnlLeft.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlEvent.SuspendLayout();
            pnlDate.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(239, 246, 255);
            pnlLeft.Controls.Add(pnlLogo);
            pnlLeft.Controls.Add(lblHeading);
            pnlLeft.Controls.Add(lblEvent);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Controls.Add(lblDescription);
            pnlLeft.Controls.Add(pnlEvent);
            pnlLeft.Controls.Add(lblSecurity);
            pnlLeft.Location = new Point(110, 8);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(592, 620);
            pnlLeft.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(37, 99, 235);
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Location = new Point(72, 52);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(48, 48);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(48, 48);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "▦";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            lblHeading.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblHeading.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeading.Location = new Point(132, 55);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(300, 45);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "HahuEvents";
            // 
            // lblEvent
            // 
            lblEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEvent.ForeColor = Color.FromArgb(37, 99, 235);
            lblEvent.Location = new Point(75, 207);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(390, 25);
            lblEvent.TabIndex = 2;
            lblEvent.Text = "EVENT REGISTRATION MANAGEMENT";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 41, 59);
            lblWelcome.Location = new Point(72, 240);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(430, 58);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome Back";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblDescription.Location = new Point(75, 310);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(430, 60);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Sign in to manage your events and\nregistrations.";
            // 
            // pnlEvent
            // 
            pnlEvent.BackColor = Color.White;
            pnlEvent.BorderStyle = BorderStyle.FixedSingle;
            pnlEvent.Controls.Add(pnlDate);
            pnlEvent.Controls.Add(lblLine1);
            pnlEvent.Controls.Add(lblLine2);
            pnlEvent.Controls.Add(lblLine3);
            pnlEvent.Location = new Point(72, 405);
            pnlEvent.Name = "pnlEvent";
            pnlEvent.Size = new Size(350, 94);
            pnlEvent.TabIndex = 5;
            // 
            // pnlDate
            // 
            pnlDate.BackColor = Color.FromArgb(239, 246, 255);
            pnlDate.Controls.Add(lblDate);
            pnlDate.Controls.Add(lblJune);
            pnlDate.Location = new Point(12, 12);
            pnlDate.Name = "pnlDate";
            pnlDate.Size = new Size(70, 68);
            pnlDate.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(37, 99, 235);
            lblDate.Location = new Point(0, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 35);
            lblDate.TabIndex = 0;
            lblDate.Text = "24";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJune
            // 
            lblJune.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblJune.ForeColor = Color.FromArgb(37, 99, 235);
            lblJune.Location = new Point(0, 48);
            lblJune.Name = "lblJune";
            lblJune.Size = new Size(70, 16);
            lblJune.TabIndex = 1;
            lblJune.Text = "JUNE";
            lblJune.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLine1
            // 
            lblLine1.BackColor = Color.FromArgb(219, 234, 254);
            lblLine1.Location = new Point(100, 24);
            lblLine1.Name = "lblLine1";
            lblLine1.Size = new Size(220, 7);
            lblLine1.TabIndex = 1;
            // 
            // lblLine2
            // 
            lblLine2.BackColor = Color.FromArgb(226, 232, 240);
            lblLine2.Location = new Point(100, 42);
            lblLine2.Name = "lblLine2";
            lblLine2.Size = new Size(175, 6);
            lblLine2.TabIndex = 2;
            // 
            // lblLine3
            // 
            lblLine3.BackColor = Color.FromArgb(226, 232, 240);
            lblLine3.Location = new Point(100, 58);
            lblLine3.Name = "lblLine3";
            lblLine3.Size = new Size(200, 6);
            lblLine3.TabIndex = 3;
            // 
            // lblSecurity
            // 
            lblSecurity.Font = new Font("Segoe UI", 9F);
            lblSecurity.ForeColor = Color.FromArgb(100, 116, 139);
            lblSecurity.Location = new Point(72, 552);
            lblSecurity.Name = "lblSecurity";
            lblSecurity.Size = new Size(390, 25);
            lblSecurity.TabIndex = 6;
            lblSecurity.Text = "Your information is protected and secure.";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblSignIn);
            pnlRight.Controls.Add(lblSubtitle);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(chkShowPassword);
            pnlRight.Controls.Add(btnSignIn);
            pnlRight.Controls.Add(lblFooter);
            pnlRight.Location = new Point(702, 8);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(468, 620);
            pnlRight.TabIndex = 1;
            // 
            // lblSignIn
            // 
            lblSignIn.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblSignIn.ForeColor = Color.FromArgb(30, 41, 59);
            lblSignIn.Location = new Point(58, 62);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(350, 48);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign In";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(60, 115);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(365, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome back! Please enter your details.";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsername.Location = new Point(60, 176);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(350, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(60, 204);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(362, 29);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location = new Point(60, 285);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(350, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(60, 313);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(362, 29);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.ForeColor = Color.FromArgb(71, 85, 105);
            chkShowPassword.Location = new Point(60, 374);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(180, 28);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(37, 99, 235);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(60, 421);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(362, 52);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(25, 550);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(418, 25);
            lblFooter.TabIndex = 8;
            lblFooter.Text = "© 2025 HahuEvents. All rights reserved.";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1176, 613);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HahuEvents - Sign In";
            Load += Form1_Load;
            pnlLeft.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlEvent.ResumeLayout(false);
            pnlDate.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}
