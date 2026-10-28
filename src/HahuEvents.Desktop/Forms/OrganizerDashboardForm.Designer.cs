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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizerDashboardForm));
            bindingSource1 = new BindingSource(components);
            pnlSidebar = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            btnMyReports = new Button();
            btnAttendance = new Button();
            btnRegistrations = new Button();
            btnCreateEvent = new Button();
            btnMyEvents = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            pnlHeader = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            button10 = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            panel4 = new Panel();
            button9 = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            button8 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            button7 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            textBox1 = new TextBox();
            label20 = new Label();
            comboBox1 = new ComboBox();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            dataGridView1 = new DataGridView();
            EventID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(panel6);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(label3);
            pnlSidebar.Controls.Add(btnMyReports);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnCreateEvent);
            pnlSidebar.Controls.Add(btnMyEvents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.ForeColor = Color.White;
            pnlSidebar.Location = new Point(-5, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(217, 704);
            pnlSidebar.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(223, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(967, 100);
            panel6.TabIndex = 3;
            // 
            // button3
            // 
            button3.ForeColor = Color.IndianRed;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(21, 662);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(129, 35);
            button3.TabIndex = 11;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(82, 25);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 0, 0);
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "HahuEvents";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(17, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(21, 106);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 8;
            label3.Text = "ORGANIZER MENU";
            label3.Click += label3_Click;
            // 
            // btnMyReports
            // 
            btnMyReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyReports.ForeColor = Color.FromArgb(102, 112, 133);
            btnMyReports.Image = (Image)resources.GetObject("btnMyReports.Image");
            btnMyReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyReports.Location = new Point(21, 462);
            btnMyReports.Name = "btnMyReports";
            btnMyReports.Padding = new Padding(10, 0, 0, 0);
            btnMyReports.Size = new Size(146, 42);
            btnMyReports.TabIndex = 7;
            btnMyReports.Text = "My Reports";
            btnMyReports.TextAlign = ContentAlignment.MiddleRight;
            btnMyReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyReports.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            btnAttendance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.FromArgb(102, 112, 133);
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(21, 400);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(10, 0, 0, 0);
            btnAttendance.Size = new Size(148, 39);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleRight;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnRegistrations
            // 
            btnRegistrations.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrations.ForeColor = Color.FromArgb(102, 112, 133);
            btnRegistrations.Image = (Image)resources.GetObject("btnRegistrations.Image");
            btnRegistrations.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrations.Location = new Point(21, 335);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Padding = new Padding(10, 0, 0, 0);
            btnRegistrations.Size = new Size(148, 42);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.White;
            btnCreateEvent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateEvent.ForeColor = Color.FromArgb(102, 112, 133);
            btnCreateEvent.Image = (Image)resources.GetObject("btnCreateEvent.Image");
            btnCreateEvent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEvent.Location = new Point(21, 269);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Padding = new Padding(10, 0, 0, 0);
            btnCreateEvent.Size = new Size(148, 37);
            btnCreateEvent.TabIndex = 4;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateEvent.UseVisualStyleBackColor = false;
            // 
            // btnMyEvents
            // 
            btnMyEvents.BackColor = Color.White;
            btnMyEvents.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyEvents.ForeColor = Color.FromArgb(102, 112, 133);
            btnMyEvents.Image = (Image)resources.GetObject("btnMyEvents.Image");
            btnMyEvents.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyEvents.Location = new Point(21, 204);
            btnMyEvents.Name = "btnMyEvents";
            btnMyEvents.Padding = new Padding(10, 0, 0, 0);
            btnMyEvents.Size = new Size(148, 36);
            btnMyEvents.TabIndex = 3;
            btnMyEvents.Text = "My Events";
            btnMyEvents.TextAlign = ContentAlignment.MiddleRight;
            btnMyEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyEvents.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(36, 87, 197);
            btnDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(19, 136);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(148, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
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
            // pnlHeader
            // 
            pnlHeader.Controls.Add(label5);
            pnlHeader.Controls.Add(label4);
            pnlHeader.Location = new Point(218, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(967, 100);
            pnlHeader.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 62);
            label5.Name = "label5";
            label5.Size = new Size(178, 15);
            label5.TabIndex = 1;
            label5.Text = "Manage  Events and Participants";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 8);
            label4.Name = "label4";
            label4.Size = new Size(289, 40);
            label4.TabIndex = 0;
            label4.Text = "Organizer Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(251, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 113);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button10);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Location = new Point(740, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 81);
            panel5.TabIndex = 3;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(245, 247, 251);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(128, 28);
            button10.Name = "button10";
            button10.Size = new Size(55, 33);
            button10.TabIndex = 3;
            button10.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 59);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 2;
            label19.Text = "scheduled";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(12, 34);
            label18.Name = "label18";
            label18.Size = new Size(28, 21);
            label18.TabIndex = 1;
            label18.Text = "13";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 15);
            label17.Name = "label17";
            label17.Size = new Size(106, 15);
            label17.TabIndex = 0;
            label17.Text = "Upcomming event";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button9);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(512, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 81);
            panel4.TabIndex = 2;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(245, 247, 251);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(119, 28);
            button9.Name = "button9";
            button9.Size = new Size(66, 33);
            button9.TabIndex = 3;
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 60);
            label16.Name = "label16";
            label16.Size = new Size(100, 15);
            label16.TabIndex = 2;
            label16.Text = "accros your event";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 36);
            label15.Name = "label15";
            label15.Size = new Size(37, 21);
            label15.TabIndex = 1;
            label15.Text = "103";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 11);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 0;
            label14.Text = "Total Regstration";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(276, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 81);
            panel3.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(245, 247, 251);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(127, 28);
            button8.Name = "button8";
            button8.Size = new Size(57, 38);
            button8.TabIndex = 3;
            button8.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 59);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 2;
            label13.Text = "Your live events";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 34);
            label12.Name = "label12";
            label12.Size = new Size(19, 21);
            label12.TabIndex = 1;
            label12.Text = "8";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 13);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 0;
            label11.Text = "Publish Events";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(22, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 81);
            panel2.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(245, 247, 251);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(143, 28);
            button7.Name = "button7";
            button7.Size = new Size(51, 38);
            button7.TabIndex = 3;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 59);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 2;
            label10.Text = "Event you Created";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 31);
            label9.Name = "label9";
            label9.Size = new Size(28, 21);
            label9.TabIndex = 1;
            label9.Text = "12";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 11);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 0;
            label8.Text = "My Events";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(224, 224, 224);
            panel7.Controls.Add(button6);
            panel7.Controls.Add(button5);
            panel7.Controls.Add(button4);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(251, 248);
            panel7.Name = "panel7";
            panel7.Size = new Size(961, 63);
            panel7.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(771, 8);
            button6.Name = "button6";
            button6.Size = new Size(133, 45);
            button6.TabIndex = 5;
            button6.Text = "View My Report";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(581, 8);
            button5.Name = "button5";
            button5.Size = new Size(141, 45);
            button5.TabIndex = 4;
            button5.Text = "Mark Attendances";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(379, 8);
            button4.Name = "button4";
            button4.Size = new Size(163, 45);
            button4.TabIndex = 3;
            button4.Text = "Manage Regstrations";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(194, 8);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 2;
            button2.Text = "Create New Event";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 38);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 1;
            label7.Text = "common organizer task";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 8);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 0;
            label6.Text = "Quick action";
            // 
            // panel8
            // 
            panel8.Controls.Add(label23);
            panel8.Controls.Add(label22);
            panel8.Location = new Point(251, 326);
            panel8.Name = "panel8";
            panel8.Size = new Size(934, 64);
            panel8.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(251, 428);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(251, 405);
            label20.Name = "label20";
            label20.Size = new Size(42, 15);
            label20.TabIndex = 6;
            label20.Text = "Search";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(516, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 7;
            // 
            // button11
            // 
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 8;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(8, 8);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 9;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(702, 428);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 10;
            button13.Text = "Search";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(898, 428);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 11;
            button14.Text = "Reset";
            button14.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(516, 405);
            label21.Name = "label21";
            label21.Size = new Size(39, 15);
            label21.TabIndex = 12;
            label21.Text = "Status";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(33, 14);
            label22.Name = "label22";
            label22.Size = new Size(61, 15);
            label22.TabIndex = 0;
            label22.Text = "My Events";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(41, 41);
            label23.Name = "label23";
            label23.Size = new Size(263, 15);
            label23.TabIndex = 1;
            label23.Text = "view and manage event created by your account";
            label23.Click += label23_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EventID, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(242, 467);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(932, 150);
            dataGridView1.TabIndex = 13;
            // 
            // EventID
            // 
            EventID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EventID.HeaderText = "EventID";
            EventID.Name = "EventID";
            EventID.ReadOnly = true;
            EventID.Width = 72;
            // 
            // Column1
            // 
            Column1.HeaderText = "Event Title";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Event Date";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Location";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Capacity";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Registered ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // panel9
            // 
            panel9.Location = new Point(210, 650);
            panel9.Name = "panel9";
            panel9.Size = new Size(975, 59);
            panel9.TabIndex = 14;
            // 
            // OrganizerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1184, 711);
            Controls.Add(panel9);
            Controls.Add(dataGridView1);
            Controls.Add(label21);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(comboBox1);
            Controls.Add(label20);
            Controls.Add(textBox1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "OrganizerDashboardForm";
            Text = "OrganizerDashboardForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
        private Button button3;
        private Button button1;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Label label7;
        private Label label6;
        private Button button10;
        private Label label19;
        private Label label18;
        private Label label17;
        private Button button9;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button button8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel8;
        private TextBox textBox1;
        private Label label20;
        private Label label23;
        private Label label22;
        private ComboBox comboBox1;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label21;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EventID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel9;
    }
}