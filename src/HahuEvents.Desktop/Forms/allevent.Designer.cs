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
            pnlSidebar.Controls.Add(lblAdministration);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(166, 703);
            pnlSidebar.TabIndex = 0;
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
        private Label lblBrand;
        private Label lblAdministration;
    }
}