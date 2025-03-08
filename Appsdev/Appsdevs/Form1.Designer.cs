namespace Appsdevs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            panel1 = new Panel();
            BBillings = new Button();
            BQrCode = new Button();
            BPatientRec = new Button();
            LabelOfUser = new Label();
            NameOfNurse = new Label();
            BAppointment = new Button();
            pictureBox2 = new PictureBox();
            BLogout = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            Company = new Label();
            BExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 94, 116);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BBillings);
            panel1.Controls.Add(BQrCode);
            panel1.Controls.Add(BPatientRec);
            panel1.Controls.Add(LabelOfUser);
            panel1.Controls.Add(NameOfNurse);
            panel1.Controls.Add(BAppointment);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BLogout);
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 793);
            panel1.TabIndex = 0;
            // 
            // BBillings
            // 
            BBillings.FlatStyle = FlatStyle.System;
            BBillings.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBillings.Location = new Point(24, 308);
            BBillings.Name = "BBillings";
            BBillings.Size = new Size(156, 41);
            BBillings.TabIndex = 12;
            BBillings.Text = "Billings";
            BBillings.UseVisualStyleBackColor = true;
            BBillings.MouseClick += BBillings_MouseClick;
            // 
            // BQrCode
            // 
            BQrCode.FlatStyle = FlatStyle.System;
            BQrCode.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BQrCode.Location = new Point(24, 238);
            BQrCode.Name = "BQrCode";
            BQrCode.Size = new Size(156, 41);
            BQrCode.TabIndex = 11;
            BQrCode.Text = "Scan QR Code";
            BQrCode.UseVisualStyleBackColor = true;
            BQrCode.MouseClick += BQrCode_MouseClick;
            // 
            // BPatientRec
            // 
            BPatientRec.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BPatientRec.Location = new Point(24, 99);
            BPatientRec.Name = "BPatientRec";
            BPatientRec.Size = new Size(156, 41);
            BPatientRec.TabIndex = 10;
            BPatientRec.Text = "Patient Record";
            BPatientRec.UseVisualStyleBackColor = true;
            BPatientRec.MouseClick += BPatientRec_MouseClick;
            // 
            // LabelOfUser
            // 
            LabelOfUser.AutoSize = true;
            LabelOfUser.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelOfUser.ForeColor = SystemColors.ButtonHighlight;
            LabelOfUser.Location = new Point(81, 38);
            LabelOfUser.Name = "LabelOfUser";
            LabelOfUser.Size = new Size(43, 17);
            LabelOfUser.TabIndex = 9;
            LabelOfUser.Text = "Nurse";
            // 
            // NameOfNurse
            // 
            NameOfNurse.AutoSize = true;
            NameOfNurse.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameOfNurse.ForeColor = SystemColors.ButtonHighlight;
            NameOfNurse.Location = new Point(81, 18);
            NameOfNurse.Name = "NameOfNurse";
            NameOfNurse.Size = new Size(100, 20);
            NameOfNurse.TabIndex = 8;
            NameOfNurse.Text = "Jacinth Cedric";
            // 
            // BAppointment
            // 
            BAppointment.FlatStyle = FlatStyle.System;
            BAppointment.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAppointment.Location = new Point(25, 167);
            BAppointment.Name = "BAppointment";
            BAppointment.Size = new Size(156, 41);
            BAppointment.TabIndex = 6;
            BAppointment.Text = "Appointment\r\n";
            BAppointment.UseVisualStyleBackColor = true;
            BAppointment.MouseClick += BAppointment_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(17, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // BLogout
            // 
            BLogout.FlatStyle = FlatStyle.System;
            BLogout.Font = new Font("Microsoft New Tai Lue", 9.75F);
            BLogout.Location = new Point(24, 622);
            BLogout.Name = "BLogout";
            BLogout.Size = new Size(156, 41);
            BLogout.TabIndex = 2;
            BLogout.Text = "Logout";
            BLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(214, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(847, 619);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 94, 113);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(Company);
            panel2.Controls.Add(BExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1061, 35);
            panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Company
            // 
            Company.AutoSize = true;
            Company.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Company.ForeColor = SystemColors.ButtonHighlight;
            Company.Location = new Point(51, 6);
            Company.Name = "Company";
            Company.Size = new Size(82, 20);
            Company.TabIndex = 9;
            Company.Text = "MediTrack";
            // 
            // BExit
            // 
            BExit.BackgroundImageLayout = ImageLayout.Zoom;
            BExit.FlatAppearance.BorderSize = 0;
            BExit.FlatStyle = FlatStyle.Flat;
            BExit.Location = new Point(1027, 3);
            BExit.Name = "BExit";
            BExit.Size = new Size(20, 25);
            BExit.TabIndex = 0;
            BExit.UseVisualStyleBackColor = true;
            BExit.Click += button6_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 223, 231);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1061, 754);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BLogout;
        private PictureBox pictureBox2;
        private Label NameOfNurse;
        private Label LabelOfUser;
        private Panel panel2;
        private Button BExit;
        private Label Company;
        private PictureBox pictureBox3;
        private Button BAppointment;
        private Button BBillings;
        private Button BQrCode;
        private Button BPatientRec;
    }
}
