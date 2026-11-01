namespace HahuEvents.Desktop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlMainCard = new Panel();
            pnlLeft = new Panel();
            lblLeftFooter = new Label();
            pnlEventCard = new Panel();
            pnlCardLine3 = new Panel();
            pnlCardLine2 = new Panel();
            pnlCardLine1 = new Panel();
            pnlDateBox = new Panel();
            lblEventMonth = new Label();
            lblEventDay = new Label();
            lblEventTag = new Label();
            lblWelcomeDesc = new Label();
            lblWelcomeHeading = new Label();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            pnlBrandIcon = new Panel();
            lblBrandIcon = new Label();
            pnlRight = new Panel();
            lblRightFooter = new Label();
            btnSignIn = new Button();
            chkShowPassword = new CheckBox();
            pnlPasswordBorder = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlUsernameBorder = new Panel();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSignInSubtitle = new Label();
            lblSignInHeading = new Label();
            pnlMainCard.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlEventCard.SuspendLayout();
            pnlDateBox.SuspendLayout();
            pnlBrandIcon.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlPasswordBorder.SuspendLayout();
            pnlUsernameBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainCard
            // 
            pnlMainCard.Anchor = AnchorStyles.None;
            pnlMainCard.BackColor = Color.White;
            pnlMainCard.Controls.Add(pnlLeft);
            pnlMainCard.Controls.Add(pnlRight);
            pnlMainCard.Location = new Point(110, 61);
            pnlMainCard.Name = "pnlMainCard";
            pnlMainCard.Size = new Size(1060, 626);
            pnlMainCard.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(242, 246, 255);
            pnlLeft.Controls.Add(lblLeftFooter);
            pnlLeft.Controls.Add(pnlEventCard);
            pnlLeft.Controls.Add(lblWelcomeDesc);
            pnlLeft.Controls.Add(lblWelcomeHeading);
            pnlLeft.Controls.Add(lblBrandSubtitle);
            pnlLeft.Controls.Add(lblBrandTitle);
            pnlLeft.Controls.Add(pnlBrandIcon);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(584, 626);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // lblLeftFooter
            // 
            lblLeftFooter.AutoSize = true;
            lblLeftFooter.Font = new Font("Segoe UI", 9.75F);
            lblLeftFooter.ForeColor = Color.FromArgb(133, 139, 150);
            lblLeftFooter.Location = new Point(58, 560);
            lblLeftFooter.Name = "lblLeftFooter";
            lblLeftFooter.Size = new Size(290, 17);
            lblLeftFooter.TabIndex = 6;
            lblLeftFooter.Text = "Secure access for administrators and organizers";
            // 
            // pnlEventCard
            // 
            pnlEventCard.BackColor = Color.White;
            pnlEventCard.Controls.Add(pnlCardLine3);
            pnlEventCard.Controls.Add(pnlCardLine2);
            pnlEventCard.Controls.Add(pnlCardLine1);
            pnlEventCard.Controls.Add(pnlDateBox);
            pnlEventCard.Location = new Point(58, 386);
            pnlEventCard.Name = "pnlEventCard";
            pnlEventCard.Size = new Size(300, 91);
            pnlEventCard.TabIndex = 5;
            // 
            // pnlCardLine3
            // 
            pnlCardLine3.BackColor = Color.FromArgb(200, 212, 232);
            pnlCardLine3.Location = new Point(92, 58);
            pnlCardLine3.Name = "pnlCardLine3";
            pnlCardLine3.Size = new Size(106, 6);
            pnlCardLine3.TabIndex = 3;
            // 
            // pnlCardLine2
            // 
            pnlCardLine2.BackColor = Color.FromArgb(218, 228, 244);
            pnlCardLine2.Location = new Point(92, 42);
            pnlCardLine2.Name = "pnlCardLine2";
            pnlCardLine2.Size = new Size(171, 6);
            pnlCardLine2.TabIndex = 2;
            // 
            // pnlCardLine1
            // 
            pnlCardLine1.BackColor = Color.FromArgb(184, 201, 234);
            pnlCardLine1.Location = new Point(92, 26);
            pnlCardLine1.Name = "pnlCardLine1";
            pnlCardLine1.Size = new Size(150, 6);
            pnlCardLine1.TabIndex = 1;
            // 
            // pnlDateBox
            // 
            pnlDateBox.BackColor = Color.FromArgb(40, 88, 199);
            pnlDateBox.Controls.Add(lblEventMonth);
            pnlDateBox.Controls.Add(lblEventDay);
            pnlDateBox.Controls.Add(lblEventTag);
            pnlDateBox.Location = new Point(13, 13);
            pnlDateBox.Name = "pnlDateBox";
            pnlDateBox.Size = new Size(65, 65);
            pnlDateBox.TabIndex = 0;
            // 
            // lblEventMonth
            // 
            lblEventMonth.Dock = DockStyle.Bottom;
            lblEventMonth.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold);
            lblEventMonth.ForeColor = Color.White;
            lblEventMonth.Location = new Point(0, 48);
            lblEventMonth.Name = "lblEventMonth";
            lblEventMonth.Size = new Size(65, 17);
            lblEventMonth.TabIndex = 2;
            lblEventMonth.Text = "JUNE";
            lblEventMonth.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEventDay
            // 
            lblEventDay.Dock = DockStyle.Fill;
            lblEventDay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEventDay.ForeColor = Color.White;
            lblEventDay.Location = new Point(0, 16);
            lblEventDay.Name = "lblEventDay";
            lblEventDay.Size = new Size(65, 49);
            lblEventDay.TabIndex = 1;
            lblEventDay.Text = "24";
            lblEventDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEventTag
            // 
            lblEventTag.Dock = DockStyle.Top;
            lblEventTag.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold);
            lblEventTag.ForeColor = Color.FromArgb(191, 219, 254);
            lblEventTag.Location = new Point(0, 0);
            lblEventTag.Name = "lblEventTag";
            lblEventTag.Size = new Size(65, 16);
            lblEventTag.TabIndex = 0;
            lblEventTag.Text = "EVENT";
            lblEventTag.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblWelcomeDesc
            // 
            lblWelcomeDesc.Font = new Font("Segoe UI", 15F);
            lblWelcomeDesc.ForeColor = Color.FromArgb(129, 137, 151);
            lblWelcomeDesc.Location = new Point(58, 303);
            lblWelcomeDesc.Name = "lblWelcomeDesc";
            lblWelcomeDesc.Size = new Size(340, 60);
            lblWelcomeDesc.TabIndex = 4;
            lblWelcomeDesc.Text = "Sign in to manage your events and\r\nregistrations.";
            // 
            // lblWelcomeHeading
            // 
            lblWelcomeHeading.AutoSize = true;
            lblWelcomeHeading.Font = new Font("Segoe UI", 32F);
            lblWelcomeHeading.ForeColor = Color.FromArgb(23, 28, 39);
            lblWelcomeHeading.Location = new Point(54, 234);
            lblWelcomeHeading.Name = "lblWelcomeHeading";
            lblWelcomeHeading.Size = new Size(299, 59);
            lblWelcomeHeading.TabIndex = 3;
            lblWelcomeHeading.Text = "Welcome Back";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(40, 88, 199);
            lblBrandSubtitle.Location = new Point(58, 208);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(241, 17);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "EVENT REGISTRATION MANAGEMENT";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.FromArgb(23, 28, 39);
            lblBrandTitle.Location = new Point(124, 64);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(148, 32);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "HahuEvents";
            // 
            // pnlBrandIcon
            // 
            pnlBrandIcon.BackColor = Color.FromArgb(40, 88, 199);
            pnlBrandIcon.Controls.Add(lblBrandIcon);
            pnlBrandIcon.Location = new Point(58, 54);
            pnlBrandIcon.Name = "pnlBrandIcon";
            pnlBrandIcon.Size = new Size(52, 52);
            pnlBrandIcon.TabIndex = 0;
            // 
            // lblBrandIcon
            // 
            lblBrandIcon.Dock = DockStyle.Fill;
            lblBrandIcon.Font = new Font("Segoe UI Symbol", 20F);
            lblBrandIcon.ForeColor = Color.White;
            lblBrandIcon.Location = new Point(0, 0);
            lblBrandIcon.Name = "lblBrandIcon";
            lblBrandIcon.Size = new Size(52, 52);
            lblBrandIcon.TabIndex = 0;
            lblBrandIcon.Text = "📅";
            lblBrandIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblRightFooter);
            pnlRight.Controls.Add(btnSignIn);
            pnlRight.Controls.Add(chkShowPassword);
            pnlRight.Controls.Add(pnlPasswordBorder);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(pnlUsernameBorder);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(lblSignInSubtitle);
            pnlRight.Controls.Add(lblSignInHeading);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(584, 0);
            pnlRight.Margin = new Padding(0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(476, 626);
            pnlRight.TabIndex = 1;
            // 
            // lblRightFooter
            // 
            lblRightFooter.Font = new Font("Segoe UI", 9F);
            lblRightFooter.ForeColor = Color.FromArgb(162, 168, 179);
            lblRightFooter.Location = new Point(58, 560);
            lblRightFooter.Name = "lblRightFooter";
            lblRightFooter.Size = new Size(362, 23);
            lblRightFooter.TabIndex = 8;
            lblRightFooter.Text = "HahuEvents   |   Event Management System";
            lblRightFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(40, 88, 199);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(58, 445);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(362, 53);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 9.75F);
            chkShowPassword.ForeColor = Color.FromArgb(133, 139, 150);
            chkShowPassword.Location = new Point(58, 393);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(118, 21);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pnlPasswordBorder
            // 
            pnlPasswordBorder.BackColor = Color.FromArgb(250, 251, 253);
            pnlPasswordBorder.Controls.Add(txtPassword);
            pnlPasswordBorder.Location = new Point(58, 317);
            pnlPasswordBorder.Name = "pnlPasswordBorder";
            pnlPasswordBorder.Padding = new Padding(15, 14, 15, 14);
            pnlPasswordBorder.Size = new Size(362, 51);
            pnlPasswordBorder.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(250, 251, 253);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(133, 139, 150);
            txtPassword.Location = new Point(15, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(332, 20);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Enter your password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(23, 28, 39);
            lblPassword.Location = new Point(58, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // pnlUsernameBorder
            // 
            pnlUsernameBorder.BackColor = Color.FromArgb(250, 251, 253);
            pnlUsernameBorder.Controls.Add(txtUsername);
            pnlUsernameBorder.Location = new Point(58, 221);
            pnlUsernameBorder.Name = "pnlUsernameBorder";
            pnlUsernameBorder.Padding = new Padding(15, 14, 15, 14);
            pnlUsernameBorder.Size = new Size(362, 51);
            pnlUsernameBorder.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(250, 251, 253);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(133, 139, 150);
            txtUsername.Location = new Point(15, 14);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(332, 20);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Enter your username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(23, 28, 39);
            lblUsername.Location = new Point(58, 194);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSignInSubtitle
            // 
            lblSignInSubtitle.AutoSize = true;
            lblSignInSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSignInSubtitle.ForeColor = Color.FromArgb(133, 139, 150);
            lblSignInSubtitle.Location = new Point(58, 137);
            lblSignInSubtitle.Name = "lblSignInSubtitle";
            lblSignInSubtitle.Size = new Size(219, 19);
            lblSignInSubtitle.TabIndex = 1;
            lblSignInSubtitle.Text = "Enter your credentials to continue.";
            // 
            // lblSignInHeading
            // 
            lblSignInHeading.AutoSize = true;
            lblSignInHeading.Font = new Font("Segoe UI", 24F);
            lblSignInHeading.ForeColor = Color.FromArgb(23, 28, 39);
            lblSignInHeading.Location = new Point(58, 86);
            lblSignInHeading.Name = "lblSignInHeading";
            lblSignInHeading.Size = new Size(118, 45);
            lblSignInHeading.TabIndex = 0;
            lblSignInHeading.Text = "Sign In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1280, 749);
            Controls.Add(pnlMainCard);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HahuEvents";
            pnlMainCard.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlEventCard.ResumeLayout(false);
            pnlDateBox.ResumeLayout(false);
            pnlBrandIcon.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlPasswordBorder.ResumeLayout(false);
            pnlPasswordBorder.PerformLayout();
            pnlUsernameBorder.ResumeLayout(false);
            pnlUsernameBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMainCard;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBrandIcon;
        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblWelcomeHeading;
        private System.Windows.Forms.Label lblWelcomeDesc;
        private System.Windows.Forms.Panel pnlEventCard;
        private System.Windows.Forms.Panel pnlDateBox;
        private System.Windows.Forms.Label lblEventTag;
        private System.Windows.Forms.Label lblEventDay;
        private System.Windows.Forms.Label lblEventMonth;
        private System.Windows.Forms.Panel pnlCardLine1;
        private System.Windows.Forms.Panel pnlCardLine2;
        private System.Windows.Forms.Panel pnlCardLine3;
        private System.Windows.Forms.Label lblLeftFooter;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblSignInHeading;
        private System.Windows.Forms.Label lblSignInSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsernameBorder;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPasswordBorder;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblRightFooter;
    }
}