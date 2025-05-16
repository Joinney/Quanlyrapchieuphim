namespace loogin.btnDulieu
{
    partial class CinemaUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowCinema = new System.Windows.Forms.Button();
            this.btnUpdateCinema = new System.Windows.Forms.Button();
            this.btnDeleteCinema = new System.Windows.Forms.Button();
            this.btnInsertCinema = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupthongtinphong = new System.Windows.Forms.GroupBox();
            this.cboCinemaScreenType = new System.Windows.Forms.ComboBox();
            this.txtSeatsPerRow = new System.Windows.Forms.TextBox();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.txtCinemaStatus = new System.Windows.Forms.TextBox();
            this.txtCinemaSeats = new System.Windows.Forms.TextBox();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.txtCinemaName = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvCinema = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupthongtinphong.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(126, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHÒNG CHIẾU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnShowCinema);
            this.panel2.Controls.Add(this.btnUpdateCinema);
            this.panel2.Controls.Add(this.btnDeleteCinema);
            this.panel2.Controls.Add(this.btnInsertCinema);
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 66);
            this.panel2.TabIndex = 1;
            // 
            // btnShowCinema
            // 
            this.btnShowCinema.Location = new System.Drawing.Point(517, 15);
            this.btnShowCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowCinema.Name = "btnShowCinema";
            this.btnShowCinema.Size = new System.Drawing.Size(96, 36);
            this.btnShowCinema.TabIndex = 3;
            this.btnShowCinema.Text = "Xem";
            this.btnShowCinema.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCinema
            // 
            this.btnUpdateCinema.Location = new System.Drawing.Point(350, 15);
            this.btnUpdateCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCinema.Name = "btnUpdateCinema";
            this.btnUpdateCinema.Size = new System.Drawing.Size(96, 36);
            this.btnUpdateCinema.TabIndex = 2;
            this.btnUpdateCinema.Text = "Sửa";
            this.btnUpdateCinema.UseVisualStyleBackColor = true;
            this.btnUpdateCinema.Click += new System.EventHandler(this.btnUpdateCinema_Click);
            // 
            // btnDeleteCinema
            // 
            this.btnDeleteCinema.Location = new System.Drawing.Point(188, 15);
            this.btnDeleteCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCinema.Name = "btnDeleteCinema";
            this.btnDeleteCinema.Size = new System.Drawing.Size(96, 36);
            this.btnDeleteCinema.TabIndex = 1;
            this.btnDeleteCinema.Text = "Xóa ";
            this.btnDeleteCinema.UseVisualStyleBackColor = true;
            this.btnDeleteCinema.Click += new System.EventHandler(this.btnDeleteCinema_Click);
            // 
            // btnInsertCinema
            // 
            this.btnInsertCinema.Location = new System.Drawing.Point(31, 15);
            this.btnInsertCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertCinema.Name = "btnInsertCinema";
            this.btnInsertCinema.Size = new System.Drawing.Size(96, 36);
            this.btnInsertCinema.TabIndex = 0;
            this.btnInsertCinema.Text = "Thêm";
            this.btnInsertCinema.UseVisualStyleBackColor = true;
            this.btnInsertCinema.Click += new System.EventHandler(this.btnInsertCinema_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(648, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 496);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupthongtinphong);
            this.panel5.Location = new System.Drawing.Point(8, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 474);
            this.panel5.TabIndex = 0;
            // 
            // groupthongtinphong
            // 
            this.groupthongtinphong.Controls.Add(this.cboCinemaScreenType);
            this.groupthongtinphong.Controls.Add(this.txtSeatsPerRow);
            this.groupthongtinphong.Controls.Add(this.txtNumberOfRows);
            this.groupthongtinphong.Controls.Add(this.txtCinemaStatus);
            this.groupthongtinphong.Controls.Add(this.txtCinemaSeats);
            this.groupthongtinphong.Controls.Add(this.txtCinemaID);
            this.groupthongtinphong.Controls.Add(this.txtCinemaName);
            this.groupthongtinphong.Controls.Add(this.label8);
            this.groupthongtinphong.Controls.Add(this.label7);
            this.groupthongtinphong.Controls.Add(this.label6);
            this.groupthongtinphong.Controls.Add(this.label5);
            this.groupthongtinphong.Controls.Add(this.label4);
            this.groupthongtinphong.Controls.Add(this.label3);
            this.groupthongtinphong.Controls.Add(this.label2);
            this.groupthongtinphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupthongtinphong.Location = new System.Drawing.Point(11, 15);
            this.groupthongtinphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupthongtinphong.Name = "groupthongtinphong";
            this.groupthongtinphong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupthongtinphong.Size = new System.Drawing.Size(304, 444);
            this.groupthongtinphong.TabIndex = 0;
            this.groupthongtinphong.TabStop = false;
            this.groupthongtinphong.Text = "Thông Tin Phòng";
            // 
            // cboCinemaScreenType
            // 
            this.cboCinemaScreenType.FormattingEnabled = true;
            this.cboCinemaScreenType.Location = new System.Drawing.Point(128, 154);
            this.cboCinemaScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCinemaScreenType.Name = "cboCinemaScreenType";
            this.cboCinemaScreenType.Size = new System.Drawing.Size(158, 37);
            this.cboCinemaScreenType.TabIndex = 12;
            // 
            // txtSeatsPerRow
            // 
            this.txtSeatsPerRow.Location = new System.Drawing.Point(128, 387);
            this.txtSeatsPerRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeatsPerRow.Name = "txtSeatsPerRow";
            this.txtSeatsPerRow.Size = new System.Drawing.Size(158, 34);
            this.txtSeatsPerRow.TabIndex = 10;
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(128, 325);
            this.txtNumberOfRows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(158, 34);
            this.txtNumberOfRows.TabIndex = 9;
            // 
            // txtCinemaStatus
            // 
            this.txtCinemaStatus.Location = new System.Drawing.Point(128, 267);
            this.txtCinemaStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCinemaStatus.Name = "txtCinemaStatus";
            this.txtCinemaStatus.Size = new System.Drawing.Size(158, 34);
            this.txtCinemaStatus.TabIndex = 8;
            // 
            // txtCinemaSeats
            // 
            this.txtCinemaSeats.Location = new System.Drawing.Point(128, 209);
            this.txtCinemaSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCinemaSeats.Name = "txtCinemaSeats";
            this.txtCinemaSeats.Size = new System.Drawing.Size(158, 34);
            this.txtCinemaSeats.TabIndex = 7;
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Location = new System.Drawing.Point(128, 49);
            this.txtCinemaID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.Size = new System.Drawing.Size(158, 34);
            this.txtCinemaID.TabIndex = 1;
            this.txtCinemaID.TextChanged += new System.EventHandler(this.txtCinemaID_TextChanged);
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Location = new System.Drawing.Point(128, 100);
            this.txtCinemaName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.Size = new System.Drawing.Size(158, 34);
            this.txtCinemaName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(14, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ghế mỗi hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(14, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số hàng ghế:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tình Trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số chỗ ngồi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Màn Hình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.dtgvCinema);
            this.panel4.Location = new System.Drawing.Point(2, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 353);
            this.panel4.TabIndex = 3;
            // 
            // dtgvCinema
            // 
            this.dtgvCinema.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinema.Location = new System.Drawing.Point(10, 13);
            this.dtgvCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvCinema.Name = "dtgvCinema";
            this.dtgvCinema.RowHeadersWidth = 51;
            this.dtgvCinema.RowTemplate.Height = 24;
            this.dtgvCinema.Size = new System.Drawing.Size(620, 332);
            this.dtgvCinema.TabIndex = 0;
            // 
            // CinemaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CinemaUC";
            this.Size = new System.Drawing.Size(1000, 498);
            this.Load += new System.EventHandler(this.CinemaUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupthongtinphong.ResumeLayout(false);
            this.groupthongtinphong.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvCinema;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupthongtinphong;
        private System.Windows.Forms.ComboBox cboCinemaScreenType;
        private System.Windows.Forms.TextBox txtSeatsPerRow;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.TextBox txtCinemaStatus;
        private System.Windows.Forms.TextBox txtCinemaSeats;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.MaskedTextBox txtCinemaName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowCinema;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnDeleteCinema;
        private System.Windows.Forms.Button btnInsertCinema;
    }
}