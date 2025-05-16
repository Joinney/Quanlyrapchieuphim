namespace loogin.btnDulieu
{
    partial class ScreenTypeUC
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
            this.btnShowScreenType = new System.Windows.Forms.Button();
            this.btnUpdateScreenType = new System.Windows.Forms.Button();
            this.btnDeleteScreenType = new System.Windows.Forms.Button();
            this.btnInsertScreenType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScreenTypeName = new System.Windows.Forms.TextBox();
            this.txtScreenTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvScreenType = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnShowScreenType);
            this.panel1.Controls.Add(this.btnUpdateScreenType);
            this.panel1.Controls.Add(this.btnDeleteScreenType);
            this.panel1.Controls.Add(this.btnInsertScreenType);
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 75);
            this.panel1.TabIndex = 2;
            // 
            // btnShowScreenType
            // 
            this.btnShowScreenType.Location = new System.Drawing.Point(789, 16);
            this.btnShowScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowScreenType.Name = "btnShowScreenType";
            this.btnShowScreenType.Size = new System.Drawing.Size(107, 41);
            this.btnShowScreenType.TabIndex = 3;
            this.btnShowScreenType.Text = "Xem";
            this.btnShowScreenType.UseVisualStyleBackColor = true;
            this.btnShowScreenType.Click += new System.EventHandler(this.btnShowScreenType_Click);
            // 
            // btnUpdateScreenType
            // 
            this.btnUpdateScreenType.Location = new System.Drawing.Point(548, 16);
            this.btnUpdateScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateScreenType.Name = "btnUpdateScreenType";
            this.btnUpdateScreenType.Size = new System.Drawing.Size(107, 41);
            this.btnUpdateScreenType.TabIndex = 2;
            this.btnUpdateScreenType.Text = "Sửa";
            this.btnUpdateScreenType.UseVisualStyleBackColor = true;
            this.btnUpdateScreenType.Click += new System.EventHandler(this.btnUpdateScreenType_Click);
            // 
            // btnDeleteScreenType
            // 
            this.btnDeleteScreenType.Location = new System.Drawing.Point(310, 16);
            this.btnDeleteScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteScreenType.Name = "btnDeleteScreenType";
            this.btnDeleteScreenType.Size = new System.Drawing.Size(107, 41);
            this.btnDeleteScreenType.TabIndex = 1;
            this.btnDeleteScreenType.Text = "Xóa\r\n";
            this.btnDeleteScreenType.UseVisualStyleBackColor = true;
            this.btnDeleteScreenType.Click += new System.EventHandler(this.btnDeleteScreenType_Click);
            // 
            // btnInsertScreenType
            // 
            this.btnInsertScreenType.Location = new System.Drawing.Point(75, 16);
            this.btnInsertScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertScreenType.Name = "btnInsertScreenType";
            this.btnInsertScreenType.Size = new System.Drawing.Size(107, 41);
            this.btnInsertScreenType.TabIndex = 0;
            this.btnInsertScreenType.Text = "Thêm";
            this.btnInsertScreenType.UseVisualStyleBackColor = true;
            this.btnInsertScreenType.Click += new System.EventHandler(this.btnInsertScreenType_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(660, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 342);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(12, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 318);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScreenTypeName);
            this.groupBox1.Controls.Add(this.txtScreenTypeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Phim";
            // 
            // txtScreenTypeName
            // 
            this.txtScreenTypeName.Location = new System.Drawing.Point(146, 150);
            this.txtScreenTypeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScreenTypeName.Multiline = true;
            this.txtScreenTypeName.Name = "txtScreenTypeName";
            this.txtScreenTypeName.Size = new System.Drawing.Size(136, 36);
            this.txtScreenTypeName.TabIndex = 3;
            // 
            // txtScreenTypeID
            // 
            this.txtScreenTypeID.Location = new System.Drawing.Point(146, 71);
            this.txtScreenTypeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScreenTypeID.Multiline = true;
            this.txtScreenTypeID.Name = "txtScreenTypeID";
            this.txtScreenTypeID.Size = new System.Drawing.Size(136, 30);
            this.txtScreenTypeID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên màn hình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại màn hình:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 72);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC LOẠI PHIM";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Controls.Add(this.dtgvScreenType);
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(656, 342);
            this.panel5.TabIndex = 5;
            // 
            // dtgvScreenType
            // 
            this.dtgvScreenType.BackgroundColor = System.Drawing.Color.White;
            this.dtgvScreenType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScreenType.GridColor = System.Drawing.Color.Black;
            this.dtgvScreenType.Location = new System.Drawing.Point(10, 12);
            this.dtgvScreenType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvScreenType.Name = "dtgvScreenType";
            this.dtgvScreenType.RowHeadersWidth = 51;
            this.dtgvScreenType.RowTemplate.Height = 24;
            this.dtgvScreenType.Size = new System.Drawing.Size(626, 318);
            this.dtgvScreenType.TabIndex = 0;
            // 
            // ScreenTypeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScreenTypeUC";
            this.Size = new System.Drawing.Size(1000, 498);
            this.Load += new System.EventHandler(this.ScreenTypeUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowScreenType;
        private System.Windows.Forms.Button btnUpdateScreenType;
        private System.Windows.Forms.Button btnDeleteScreenType;
        private System.Windows.Forms.Button btnInsertScreenType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtScreenTypeName;
        private System.Windows.Forms.TextBox txtScreenTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}