namespace HahuEvents.Desktop.Forms
{
    partial class OrganizerDashboardForm
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            pnlSidebar = new Panel();
            btnMyEvents = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            panel1 = new Panel();
            btnCreateEvent = new Button();
            btnRegistrations = new Button();
            btnAttendance = new Button();
            btnMyReports = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnMyReports);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnCreateEvent);
            pnlSidebar.Controls.Add(btnMyEvents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.ForeColor = Color.White;
            pnlSidebar.Location = new Point(-5, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(206, 707);
            pnlSidebar.TabIndex = 0;
            // 
            // btnMyEvents
            // 
            btnMyEvents.BackColor = Color.Transparent;
            btnMyEvents.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyEvents.ForeColor = Color.FromArgb(102, 112, 133);
            btnMyEvents.Location = new Point(21, 204);
            btnMyEvents.Name = "btnMyEvents";
            btnMyEvents.Size = new Size(148, 36);
            btnMyEvents.TabIndex = 3;
            btnMyEvents.Text = "My Events";
            btnMyEvents.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(36, 87, 197);
            btnDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(21, 135);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(148, 39);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 106);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "ORGANIZER  MENU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "HahuEvents";
            // 
            // pnlHeader
            // 
            pnlHeader.Location = new Point(207, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(978, 100);
            pnlHeader.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(207, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 113);
            panel1.TabIndex = 2;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.Transparent;
            btnCreateEvent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateEvent.ForeColor = Color.FromArgb(102, 112, 133);
            btnCreateEvent.Location = new Point(21, 269);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(148, 37);
            btnCreateEvent.TabIndex = 4;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = false;
            // 
            // btnRegistrations
            // 
            btnRegistrations.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrations.ForeColor = Color.FromArgb(102, 112, 133);
            btnRegistrations.Location = new Point(21, 335);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(148, 42);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            btnAttendance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.FromArgb(102, 112, 133);
            btnAttendance.Location = new Point(21, 400);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(148, 39);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnMyReports
            // 
            btnMyReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyReports.ForeColor = Color.FromArgb(102, 112, 133);
            btnMyReports.Location = new Point(21, 462);
            btnMyReports.Name = "btnMyReports";
            btnMyReports.Size = new Size(146, 42);
            btnMyReports.TabIndex = 7;
            btnMyReports.Text = "My Reports";
            btnMyReports.UseVisualStyleBackColor = true;
            // 
            // OrganizerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "OrganizerDashboardForm";
            Text = "OrganizerDashboardForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnRegistrations;
        private Button btnAttendance;
        private Button btnMyEvents;
        private Button btnDashboard;
        private Button btnCreateEvent;
        private Button btnMyReports;
    }
}