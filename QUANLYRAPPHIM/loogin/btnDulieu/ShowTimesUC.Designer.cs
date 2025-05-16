namespace loogin.btnDulieu
{
    partial class ShowTimesUC
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormatID_Showtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCinemaID_Showtime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScreenTypeName_Showtime = new System.Windows.Forms.TextBox();
            this.txtMovieName_Showtime = new System.Windows.Forms.TextBox();
            this.txtTicketPrice_Showtime = new System.Windows.Forms.TextBox();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel46 = new System.Windows.Forms.Panel();
            this.btnSearchShowtime = new System.Windows.Forms.Button();
            this.txtSearchShowtime = new System.Windows.Forms.TextBox();
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.panel99 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnShowShowtime = new System.Windows.Forms.Button();
            this.btnUpdateShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.btnInsertShowtime = new System.Windows.Forms.Button();
            this.groupthongtinphong = new System.Windows.Forms.GroupBox();
            this.panel88 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.panel46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).BeginInit();
            this.panel99.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupthongtinphong.SuspendLayout();
            this.panel88.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(287, 80);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(110, 45);
            this.dtmShowtimeTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(163, 30);
            this.dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(110, 16);
            this.dtmShowtimeDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(163, 30);
            this.dtmShowtimeDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // cboFormatID_Showtime
            // 
            this.cboFormatID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatID_Showtime.FormattingEnabled = true;
            this.cboFormatID_Showtime.Location = new System.Drawing.Point(119, 109);
            this.cboFormatID_Showtime.Margin = new System.Windows.Forms.Padding(2);
            this.cboFormatID_Showtime.Name = "cboFormatID_Showtime";
            this.cboFormatID_Showtime.Size = new System.Drawing.Size(163, 37);
            this.cboFormatID_Showtime.TabIndex = 39;
            this.cboFormatID_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboFormatID_Showtime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã định dạng:";
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(119, 227);
            this.cboCinemaID_Showtime.Margin = new System.Windows.Forms.Padding(2);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(163, 37);
            this.cboCinemaID_Showtime.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Giá vé:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Màn hình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Phim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Mã lịch chiếu:";
            // 
            // txtScreenTypeName_Showtime
            // 
            this.txtScreenTypeName_Showtime.BackColor = System.Drawing.Color.White;
            this.txtScreenTypeName_Showtime.Location = new System.Drawing.Point(119, 182);
            this.txtScreenTypeName_Showtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreenTypeName_Showtime.Name = "txtScreenTypeName_Showtime";
            this.txtScreenTypeName_Showtime.ReadOnly = true;
            this.txtScreenTypeName_Showtime.Size = new System.Drawing.Size(163, 34);
            this.txtScreenTypeName_Showtime.TabIndex = 29;
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.BackColor = System.Drawing.Color.White;
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(119, 143);
            this.txtMovieName_Showtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(163, 34);
            this.txtMovieName_Showtime.TabIndex = 30;
            // 
            // txtTicketPrice_Showtime
            // 
            this.txtTicketPrice_Showtime.Location = new System.Drawing.Point(119, 370);
            this.txtTicketPrice_Showtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            this.txtTicketPrice_Showtime.Size = new System.Drawing.Size(163, 34);
            this.txtTicketPrice_Showtime.TabIndex = 31;
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(119, 63);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(163, 34);
            this.txtShowtimeID.TabIndex = 32;
            this.txtShowtimeID.TextChanged += new System.EventHandler(this.txtShowtimeID_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH LỊCH CHIẾU ";
            // 
            // panel46
            // 
            this.panel46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel46.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel46.Controls.Add(this.btnSearchShowtime);
            this.panel46.Controls.Add(this.txtSearchShowtime);
            this.panel46.Controls.Add(this.dtgvShowtime);
            this.panel46.Location = new System.Drawing.Point(2, 71);
            this.panel46.Margin = new System.Windows.Forms.Padding(2);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(641, 353);
            this.panel46.TabIndex = 20;
            // 
            // btnSearchShowtime
            // 
            this.btnSearchShowtime.Location = new System.Drawing.Point(440, 20);
            this.btnSearchShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchShowtime.Name = "btnSearchShowtime";
            this.btnSearchShowtime.Size = new System.Drawing.Size(20, 22);
            this.btnSearchShowtime.TabIndex = 9;
            this.btnSearchShowtime.UseVisualStyleBackColor = true;
            this.btnSearchShowtime.Click += new System.EventHandler(this.btnSearchShowtime_Click);
            // 
            // txtSearchShowtime
            // 
            this.txtSearchShowtime.Location = new System.Drawing.Point(185, 20);
            this.txtSearchShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchShowtime.Multiline = true;
            this.txtSearchShowtime.Name = "txtSearchShowtime";
            this.txtSearchShowtime.Size = new System.Drawing.Size(252, 23);
            this.txtSearchShowtime.TabIndex = 8;
            this.txtSearchShowtime.Text = "Tìm theo tên phim...";
            // Gán sự kiện KeyDown
            this.txtSearchShowtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchShowtime_TextChanged);


            // 
            // dtgvShowtime
            // 
            this.dtgvShowtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvShowtime.BackgroundColor = System.Drawing.Color.White;
            this.dtgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowtime.Location = new System.Drawing.Point(10, 51);
            this.dtgvShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvShowtime.Name = "dtgvShowtime";
            this.dtgvShowtime.RowHeadersWidth = 51;
            this.dtgvShowtime.RowTemplate.Height = 24;
            this.dtgvShowtime.Size = new System.Drawing.Size(620, 294);
            this.dtgvShowtime.TabIndex = 0;
            // 
            // panel99
            // 
            this.panel99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel99.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel99.Controls.Add(this.label1);
            this.panel99.Location = new System.Drawing.Point(0, 0);
            this.panel99.Margin = new System.Windows.Forms.Padding(2);
            this.panel99.Name = "panel99";
            this.panel99.Size = new System.Drawing.Size(644, 66);
            this.panel99.TabIndex = 19;
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel15.Controls.Add(this.btnShowShowtime);
            this.panel15.Controls.Add(this.btnUpdateShowtime);
            this.panel15.Controls.Add(this.btnDeleteShowtime);
            this.panel15.Controls.Add(this.btnInsertShowtime);
            this.panel15.Location = new System.Drawing.Point(2, 432);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(644, 66);
            this.panel15.TabIndex = 18;
            // 
            // btnShowShowtime
            // 
            this.btnShowShowtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowShowtime.Location = new System.Drawing.Point(517, 15);
            this.btnShowShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowShowtime.Name = "btnShowShowtime";
            this.btnShowShowtime.Size = new System.Drawing.Size(96, 36);
            this.btnShowShowtime.TabIndex = 7;
            this.btnShowShowtime.Text = "Xem";
            this.btnShowShowtime.UseVisualStyleBackColor = true;
            this.btnShowShowtime.Click += new System.EventHandler(this.btnShowShowtime_Click);
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateShowtime.Location = new System.Drawing.Point(350, 15);
            this.btnUpdateShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(96, 36);
            this.btnUpdateShowtime.TabIndex = 6;
            this.btnUpdateShowtime.Text = "Sửa";
            this.btnUpdateShowtime.UseVisualStyleBackColor = true;
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(188, 15);
            this.btnDeleteShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(96, 36);
            this.btnDeleteShowtime.TabIndex = 5;
            this.btnDeleteShowtime.Text = "Xóa ";
            this.btnDeleteShowtime.UseVisualStyleBackColor = true;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnInsertShowtime
            // 
            this.btnInsertShowtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertShowtime.Location = new System.Drawing.Point(31, 15);
            this.btnInsertShowtime.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertShowtime.Name = "btnInsertShowtime";
            this.btnInsertShowtime.Size = new System.Drawing.Size(96, 36);
            this.btnInsertShowtime.TabIndex = 4;
            this.btnInsertShowtime.Text = "Thêm";
            this.btnInsertShowtime.UseVisualStyleBackColor = true;
            this.btnInsertShowtime.Click += new System.EventHandler(this.btnInsertShowtime_Click);
            // 
            // groupthongtinphong
            // 
            this.groupthongtinphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupthongtinphong.Controls.Add(this.groupBox2);
            this.groupthongtinphong.Controls.Add(this.cboFormatID_Showtime);
            this.groupthongtinphong.Controls.Add(this.label3);
            this.groupthongtinphong.Controls.Add(this.cboCinemaID_Showtime);
            this.groupthongtinphong.Controls.Add(this.label2);
            this.groupthongtinphong.Controls.Add(this.label7);
            this.groupthongtinphong.Controls.Add(this.label8);
            this.groupthongtinphong.Controls.Add(this.label4);
            this.groupthongtinphong.Controls.Add(this.label9);
            this.groupthongtinphong.Controls.Add(this.txtScreenTypeName_Showtime);
            this.groupthongtinphong.Controls.Add(this.txtMovieName_Showtime);
            this.groupthongtinphong.Controls.Add(this.txtTicketPrice_Showtime);
            this.groupthongtinphong.Controls.Add(this.txtShowtimeID);
            this.groupthongtinphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupthongtinphong.Location = new System.Drawing.Point(14, 15);
            this.groupthongtinphong.Margin = new System.Windows.Forms.Padding(2);
            this.groupthongtinphong.Name = "groupthongtinphong";
            this.groupthongtinphong.Padding = new System.Windows.Forms.Padding(2);
            this.groupthongtinphong.Size = new System.Drawing.Size(304, 444);
            this.groupthongtinphong.TabIndex = 1;
            this.groupthongtinphong.TabStop = false;
            this.groupthongtinphong.Text = "Thông Tin Thể Loại Phim";
            // 
            // panel88
            // 
            this.panel88.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel88.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel88.Controls.Add(this.panel5);
            this.panel88.Location = new System.Drawing.Point(650, 2);
            this.panel88.Margin = new System.Windows.Forms.Padding(2);
            this.panel88.Name = "panel88";
            this.panel88.Size = new System.Drawing.Size(352, 496);
            this.panel88.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupthongtinphong);
            this.panel5.Location = new System.Drawing.Point(8, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 474);
            this.panel5.TabIndex = 0;
            // 
            // ShowTimesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel46);
            this.Controls.Add(this.panel99);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel88);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowTimesUC";
            this.Size = new System.Drawing.Size(1002, 498);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).EndInit();
            this.panel99.ResumeLayout(false);
            this.panel99.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.groupthongtinphong.ResumeLayout(false);
            this.groupthongtinphong.PerformLayout();
            this.panel88.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipCinema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtmShowtimeTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmShowtimeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFormatID_Showtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCinemaID_Showtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtScreenTypeName_Showtime;
        private System.Windows.Forms.TextBox txtMovieName_Showtime;
        private System.Windows.Forms.TextBox txtTicketPrice_Showtime;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.TextBox txtSearchShowtime;
        private System.Windows.Forms.DataGridView dtgvShowtime;
        private System.Windows.Forms.Panel panel99;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnShowShowtime;
        private System.Windows.Forms.Button btnUpdateShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Button btnInsertShowtime;
        private System.Windows.Forms.GroupBox groupthongtinphong;
        private System.Windows.Forms.Panel panel88;
        private System.Windows.Forms.Panel panel5;
    }
}