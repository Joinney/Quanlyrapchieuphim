namespace loogin.btnDulieu
{
    partial class GenreUC
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
            this.panel99 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnShowGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.panel88 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupthongtinphong = new System.Windows.Forms.GroupBox();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.txtGenreName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel46 = new System.Windows.Forms.Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.panel99.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel88.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupthongtinphong.SuspendLayout();
            this.panel46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel99
            // 
            this.panel99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel99.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel99.Controls.Add(this.label1);
            this.panel99.Location = new System.Drawing.Point(0, 2);
            this.panel99.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel99.Name = "panel99";
            this.panel99.Size = new System.Drawing.Size(644, 66);
            this.panel99.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(161, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH THỂ LOẠI ";
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel15.Controls.Add(this.btnShowGenre);
            this.panel15.Controls.Add(this.btnUpdateGenre);
            this.panel15.Controls.Add(this.btnDeleteGenre);
            this.panel15.Controls.Add(this.btnInsertGenre);
            this.panel15.Location = new System.Drawing.Point(0, 432);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(644, 66);
            this.panel15.TabIndex = 2;
            // 
            // btnShowGenre
            // 
            this.btnShowGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowGenre.Location = new System.Drawing.Point(517, 15);
            this.btnShowGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowGenre.Name = "btnShowGenre";
            this.btnShowGenre.Size = new System.Drawing.Size(96, 36);
            this.btnShowGenre.TabIndex = 7;
            this.btnShowGenre.Text = "Xem";
            this.btnShowGenre.UseVisualStyleBackColor = true;
            this.btnShowGenre.Click += new System.EventHandler(this.btnShowGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateGenre.Location = new System.Drawing.Point(350, 15);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(96, 36);
            this.btnUpdateGenre.TabIndex = 6;
            this.btnUpdateGenre.Text = "Sửa";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteGenre.Location = new System.Drawing.Point(188, 15);
            this.btnDeleteGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(96, 36);
            this.btnDeleteGenre.TabIndex = 5;
            this.btnDeleteGenre.Text = "Xóa ";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertGenre.Location = new System.Drawing.Point(31, 15);
            this.btnInsertGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(96, 36);
            this.btnInsertGenre.TabIndex = 4;
            this.btnInsertGenre.Text = "Thêm";
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click);
            // 
            // panel88
            // 
            this.panel88.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel88.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel88.Controls.Add(this.panel5);
            this.panel88.Location = new System.Drawing.Point(649, 2);
            this.panel88.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel88.Name = "panel88";
            this.panel88.Size = new System.Drawing.Size(352, 496);
            this.panel88.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.groupthongtinphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupthongtinphong.Controls.Add(this.txtGenreDesc);
            this.groupthongtinphong.Controls.Add(this.txtGenreID);
            this.groupthongtinphong.Controls.Add(this.txtGenreName);
            this.groupthongtinphong.Controls.Add(this.label4);
            this.groupthongtinphong.Controls.Add(this.label3);
            this.groupthongtinphong.Controls.Add(this.label2);
            this.groupthongtinphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupthongtinphong.Location = new System.Drawing.Point(14, 15);
            this.groupthongtinphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupthongtinphong.Name = "groupthongtinphong";
            this.groupthongtinphong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupthongtinphong.Size = new System.Drawing.Size(304, 444);
            this.groupthongtinphong.TabIndex = 1;
            this.groupthongtinphong.TabStop = false;
            this.groupthongtinphong.Text = "Thông Tin Thể Loại Phim";
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenreDesc.Location = new System.Drawing.Point(74, 231);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(211, 160);
            this.txtGenreDesc.TabIndex = 7;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenreID.Location = new System.Drawing.Point(125, 67);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(158, 34);
            this.txtGenreID.TabIndex = 1;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGenreName.Location = new System.Drawing.Point(125, 137);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(161, 34);
            this.txtGenreName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô Tả:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Thể Loại:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Loại Phim:";
            // 
            // panel46
            // 
            this.panel46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel46.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel46.Controls.Add(this.dtgvGenre);
            this.panel46.Location = new System.Drawing.Point(2, 74);
            this.panel46.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(641, 353);
            this.panel46.TabIndex = 4;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.BackgroundColor = System.Drawing.Color.White;
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Location = new System.Drawing.Point(10, 15);
            this.dtgvGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.RowHeadersWidth = 51;
            this.dtgvGenre.RowTemplate.Height = 24;
            this.dtgvGenre.Size = new System.Drawing.Size(622, 330);
            this.dtgvGenre.TabIndex = 0;
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel46);
            this.Controls.Add(this.panel88);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel99);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1000, 498);
            this.Load += new System.EventHandler(this.GenreUC_Load);
            this.panel99.ResumeLayout(false);
            this.panel99.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel88.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupthongtinphong.ResumeLayout(false);
            this.groupthongtinphong.PerformLayout();
            this.panel46.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel99;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel88;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Button btnShowGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
        private System.Windows.Forms.GroupBox groupthongtinphong;
        private System.Windows.Forms.TextBox txtGenreDesc;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.MaskedTextBox txtGenreName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvGenre;
    }
}