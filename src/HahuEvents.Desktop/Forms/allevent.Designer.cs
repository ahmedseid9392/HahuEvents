namespace HahuEvents.Desktop.Forms
{
    partial class allevent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnDashboard = new Button();
            btnAllEvents = new Button();
            btnOrganizers = new Button();
            btnRegistrations = new Button();
            btnReports = new Button();
            lblBrand = new Label();
            lblAdministration = new Label();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(pnlSidebar);
            this.Name = "allevent";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "All Events";
            pnlSidebar.BackColor = Color.FromArgb(230, 237, 245);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnOrganizers);
            pnlSidebar.Controls.Add(btnAllEvents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAdministration);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(166, 703);
            pnlSidebar.TabIndex = 0;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(7, 86);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(145, 32);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnAllEvents.BackColor = Color.FromArgb(36, 87, 197);
            btnAllEvents.FlatAppearance.BorderSize = 0;
            btnAllEvents.FlatStyle = FlatStyle.Flat;
            btnAllEvents.ForeColor = Color.White;
            btnAllEvents.Location = new Point(7, 122);
            btnAllEvents.Name = "btnAllEvents";
            btnAllEvents.Size = new Size(145, 32);
            btnAllEvents.TabIndex = 3;
            btnAllEvents.Text = "All Events";
            btnAllEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnAllEvents.UseVisualStyleBackColor = false;
            btnOrganizers.FlatAppearance.BorderSize = 0;
            btnOrganizers.FlatStyle = FlatStyle.Flat;
            btnOrganizers.Location = new Point(7, 158);
            btnOrganizers.Name = "btnOrganizers";
            btnOrganizers.Size = new Size(145, 32);
            btnOrganizers.TabIndex = 4;
            btnOrganizers.Text = "Organizers";
            btnOrganizers.TextAlign = ContentAlignment.MiddleLeft;
            btnOrganizers.UseVisualStyleBackColor = true;
            btnRegistrations.FlatAppearance.BorderSize = 0;
            btnRegistrations.FlatStyle = FlatStyle.Flat;
            btnRegistrations.Location = new Point(7, 194);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(145, 32);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrations.UseVisualStyleBackColor = true;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(7, 230);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(145, 32);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(23, 32, 51);
            lblBrand.Location = new Point(12, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(103, 23);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "HahuEvents";
            lblAdministration.AutoSize = true;
            lblAdministration.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblAdministration.ForeColor = Color.FromArgb(102, 112, 133);
            lblAdministration.Location = new Point(12, 46);
            lblAdministration.Name = "lblAdministration";
            lblAdministration.Size = new Size(110, 15);
            lblAdministration.TabIndex = 1;
            lblAdministration.Text = "ADMINISTRATION";
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnDashboard;
        private Button btnAllEvents;
        private Button btnOrganizers;
        private Button btnRegistrations;
        private Button btnReports;
        private Label lblBrand;
        private Label lblAdministration;
    }
}