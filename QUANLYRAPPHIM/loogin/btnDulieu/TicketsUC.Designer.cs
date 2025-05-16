namespace loogin.btnDulieu
{
    partial class TicketsUC
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
            this.btnShowAllTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnShowAllTicketsBoughtByShowTime = new System.Windows.Forms.Button();
            this.btnAddTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.btnShowShowTimeNotCreateTickets = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnShowAllTicketsByShowTime);
            this.panel1.Controls.Add(this.btnShowAllTicketsBoughtByShowTime);
            this.panel1.Controls.Add(this.btnAddTicketsByShowTime);
            this.panel1.Controls.Add(this.btnAllListShowTimes);
            this.panel1.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.panel1.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 92);
            this.panel1.TabIndex = 6;
            // 
            // btnShowAllTicketsByShowTime
            // 
            this.btnShowAllTicketsByShowTime.Location = new System.Drawing.Point(731, 18);
            this.btnShowAllTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            this.btnShowAllTicketsByShowTime.Size = new System.Drawing.Size(155, 57);
            this.btnShowAllTicketsByShowTime.TabIndex = 11;
            this.btnShowAllTicketsByShowTime.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnShowAllTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnShowAllTicketsByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsByShowTime_Click);
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            this.btnShowAllTicketsBoughtByShowTime.Location = new System.Drawing.Point(491, 18);
            this.btnShowAllTicketsBoughtByShowTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            this.btnShowAllTicketsBoughtByShowTime.Size = new System.Drawing.Size(155, 57);
            this.btnShowAllTicketsBoughtByShowTime.TabIndex = 10;
            this.btnShowAllTicketsBoughtByShowTime.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnShowAllTicketsBoughtByShowTime.UseVisualStyleBackColor = true;
            this.btnShowAllTicketsBoughtByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsBoughtByShowTime_Click);
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(13, 18);
            this.btnAddTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(155, 57);
            this.btnAddTicketsByShowTime.TabIndex = 6;
            this.btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            this.btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click);
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Location = new System.Drawing.Point(1168, 18);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(155, 57);
            this.btnAllListShowTimes.TabIndex = 8;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            this.btnAllListShowTimes.UseVisualStyleBackColor = true;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click);
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(951, 18);
            this.btnShowShowTimeNotCreateTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(155, 57);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 9;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            this.btnShowShowTimeNotCreateTickets.Click += new System.EventHandler(this.btnShowShowTimeNotCreateTickets_Click);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(260, 18);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(155, 57);
            this.btnDeleteTicketsByShowTime.TabIndex = 7;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.lsvAllListShowTimes);
            this.panel2.Location = new System.Drawing.Point(692, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 421);
            this.panel2.TabIndex = 7;
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(16, 15);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(615, 390);
            this.lsvAllListShowTimes.TabIndex = 10;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.Width = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1333, 89);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(516, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP VÉ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Controls.Add(this.dtgvTicket);
            this.panel5.Location = new System.Drawing.Point(0, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(685, 421);
            this.panel5.TabIndex = 9;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.GridColor = System.Drawing.Color.Black;
            this.dtgvTicket.Location = new System.Drawing.Point(13, 15);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.RowTemplate.Height = 24;
            this.dtgvTicket.Size = new System.Drawing.Size(657, 391);
            this.dtgvTicket.TabIndex = 0;
            this.dtgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTicket_CellContentClick);
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1333, 613);
            this.Load += new System.EventHandler(this.TicketsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.Button btnShowAllTicketsByShowTime;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}