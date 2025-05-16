namespace loogin
{
    partial class MainForm
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
            this.wellcom = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.võDuyToànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyễnThịHuyềnDiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountUC = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRevenueUC = new System.Windows.Forms.Button();
            this.btnCustomerUC = new System.Windows.Forms.Button();
            this.btnStaffUC = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CenterPanel0 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.CenterPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wellcom
            // 
            this.wellcom.Name = "wellcom";
            this.wellcom.Size = new System.Drawing.Size(89, 24);
            this.wellcom.Text = "Wellcom !";
            this.wellcom.Click += new System.EventHandler(this.wellcom_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.võDuyToànToolStripMenuItem,
            this.nguyễnThịHuyềnDiệuToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // võDuyToànToolStripMenuItem
            // 
            this.võDuyToànToolStripMenuItem.Image = global::loogin.Properties.Resources.users;
            this.võDuyToànToolStripMenuItem.Name = "võDuyToànToolStripMenuItem";
            this.võDuyToànToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.võDuyToànToolStripMenuItem.Text = "2200002076 - Võ Duy Toàn";
            // 
            // nguyễnThịHuyềnDiệuToolStripMenuItem
            // 
            this.nguyễnThịHuyềnDiệuToolStripMenuItem.Image = global::loogin.Properties.Resources.usersn;
            this.nguyễnThịHuyềnDiệuToolStripMenuItem.Name = "nguyễnThịHuyềnDiệuToolStripMenuItem";
            this.nguyễnThịHuyềnDiệuToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.nguyễnThịHuyềnDiệuToolStripMenuItem.Text = "2200001765 - Nguyễn Thị Huyền Diệu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wellcom,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1231, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAccountUC);
            this.panel1.Controls.Add(this.btndangxuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRevenueUC);
            this.panel1.Controls.Add(this.btnCustomerUC);
            this.panel1.Controls.Add(this.btnStaffUC);
            this.panel1.Controls.Add(this.btnhanghoa);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 600);
            this.panel1.TabIndex = 4;
            // 
            // btnAccountUC
            // 
            this.btnAccountUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAccountUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccountUC.Image = global::loogin.Properties.Resources.login_user_profile_account_logout_people_man_human_512;
            this.btnAccountUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountUC.Location = new System.Drawing.Point(15, 434);
            this.btnAccountUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccountUC.Name = "btnAccountUC";
            this.btnAccountUC.Size = new System.Drawing.Size(147, 42);
            this.btnAccountUC.TabIndex = 9;
            this.btnAccountUC.Text = "Tài Khoản ";
            this.btnAccountUC.UseVisualStyleBackColor = false;
            this.btnAccountUC.Click += new System.EventHandler(this.btnAccountUC_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangxuat.Location = new System.Drawing.Point(15, 541);
            this.btndangxuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(147, 42);
            this.btndangxuat.TabIndex = 8;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin";
            // 
            // btnRevenueUC
            // 
            this.btnRevenueUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRevenueUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRevenueUC.Image = global::loogin.Properties.Resources.pie_chart;
            this.btnRevenueUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenueUC.Location = new System.Drawing.Point(15, 370);
            this.btnRevenueUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevenueUC.Name = "btnRevenueUC";
            this.btnRevenueUC.Size = new System.Drawing.Size(147, 42);
            this.btnRevenueUC.TabIndex = 4;
            this.btnRevenueUC.Text = "Doanh Thu";
            this.btnRevenueUC.UseVisualStyleBackColor = false;
            this.btnRevenueUC.Click += new System.EventHandler(this.btnRevenueUC_Click);
            // 
            // btnCustomerUC
            // 
            this.btnCustomerUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCustomerUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCustomerUC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomerUC.Image = global::loogin.Properties.Resources.people_2_512;
            this.btnCustomerUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerUC.Location = new System.Drawing.Point(15, 302);
            this.btnCustomerUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerUC.Name = "btnCustomerUC";
            this.btnCustomerUC.Size = new System.Drawing.Size(147, 42);
            this.btnCustomerUC.TabIndex = 3;
            this.btnCustomerUC.Text = "Khách Hàng ";
            this.btnCustomerUC.UseVisualStyleBackColor = false;
            this.btnCustomerUC.Click += new System.EventHandler(this.btnCustomerUC_Click);
            // 
            // btnStaffUC
            // 
            this.btnStaffUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStaffUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStaffUC.Image = global::loogin.Properties.Resources.employee_office_staff_3d735bc691173bb5_256x2561;
            this.btnStaffUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffUC.Location = new System.Drawing.Point(15, 232);
            this.btnStaffUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStaffUC.Name = "btnStaffUC";
            this.btnStaffUC.Size = new System.Drawing.Size(147, 42);
            this.btnStaffUC.TabIndex = 2;
            this.btnStaffUC.Text = "Nhân Viên";
            this.btnStaffUC.UseVisualStyleBackColor = false;
            this.btnStaffUC.Click += new System.EventHandler(this.btnStaffUC_Click);
            // 
            // btnhanghoa
            // 
            this.btnhanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhanghoa.Image = global::loogin.Properties.Resources.openfolder_48961;
            this.btnhanghoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhanghoa.Location = new System.Drawing.Point(15, 167);
            this.btnhanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(147, 42);
            this.btnhanghoa.TabIndex = 1;
            this.btnhanghoa.Text = "Dữ Liệu";
            this.btnhanghoa.UseVisualStyleBackColor = false;
            this.btnhanghoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loogin.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 605);
            this.panel2.TabIndex = 4;
            // 
            // CenterPanel0
            // 
            this.CenterPanel0.Controls.Add(this.label7);
            this.CenterPanel0.Controls.Add(this.label6);
            this.CenterPanel0.Controls.Add(this.label5);
            this.CenterPanel0.Controls.Add(this.label4);
            this.CenterPanel0.Controls.Add(this.label3);
            this.CenterPanel0.Controls.Add(this.label2);
            this.CenterPanel0.Controls.Add(this.pictureBox2);
            this.CenterPanel0.Location = new System.Drawing.Point(9, 13);
            this.CenterPanel0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CenterPanel0.Name = "CenterPanel0";
            this.CenterPanel0.Size = new System.Drawing.Size(1001, 575);
            this.CenterPanel0.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(208, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành Viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(392, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nguyễn Thị Huyền Diệu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(430, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Võ Duy Toàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(82, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1028, 80);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chương Trình Quản lý Rạp Chiếu Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(573, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIIE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(297, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "CGV G2TD | ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::loogin.Properties.Resources.welcom;
            this.pictureBox2.Location = new System.Drawing.Point(212, 263);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(587, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.White;
            this.CenterPanel.Controls.Add(this.CenterPanel0);
            this.CenterPanel.Location = new System.Drawing.Point(201, 30);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1019, 600);
            this.CenterPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1231, 633);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN ADMIN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.CenterPanel0.ResumeLayout(false);
            this.CenterPanel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem wellcom;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem võDuyToànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyễnThịHuyềnDiệuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccountUC;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRevenueUC;
        private System.Windows.Forms.Button btnCustomerUC;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnhanghoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CenterPanel0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel CenterPanel;
    }
}