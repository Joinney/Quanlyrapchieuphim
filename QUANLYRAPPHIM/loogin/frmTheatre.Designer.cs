namespace loogin
{
    partial class frmTheatre
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
            this.bntquaylai = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.btnFreeTicket = new System.Windows.Forms.Button();
            this.numericFreeTickets = new System.Windows.Forms.NumericUpDown();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.TextBox();
            this.lblPlusPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.grpLoaiVe = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.TextBox();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnthemkhachhang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeTickets)).BeginInit();
            this.grpLoaiVe.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnthemkhachhang);
            this.panel1.Controls.Add(this.bntquaylai);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblInformation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 91);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bntquaylai
            // 
            this.bntquaylai.Location = new System.Drawing.Point(1340, 18);
            this.bntquaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntquaylai.Name = "bntquaylai";
            this.bntquaylai.Size = new System.Drawing.Size(149, 49);
            this.bntquaylai.TabIndex = 2;
            this.bntquaylai.Text = "Quay Lạii";
            this.bntquaylai.UseVisualStyleBackColor = true;
            this.bntquaylai.Click += new System.EventHandler(this.bntquaylai_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.Location = new System.Drawing.Point(3, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 32);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInformation.Location = new System.Drawing.Point(3, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(133, 32);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Thông tin";
            this.lblInformation.Click += new System.EventHandler(this.lblInformation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnPayment);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.lblPayment);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(13, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(404, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh Toán";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(237, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPayment.Location = new System.Drawing.Point(27, 244);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(159, 44);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Thanh Toán ";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.Location = new System.Drawing.Point(199, 47);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(192, 30);
            this.lblTotal.TabIndex = 13;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.Location = new System.Drawing.Point(203, 124);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(188, 30);
            this.lblDiscount.TabIndex = 12;
            // 
            // lblPayment
            // 
            this.lblPayment.Location = new System.Drawing.Point(199, 194);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(192, 34);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.TextChanged += new System.EventHandler(this.lblPayment_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(29, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Số tiền cần trả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(29, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số tiền giảm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(29, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng Tiền:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pnCustomer);
            this.groupBox2.Controls.Add(this.chkCustomer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(11, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(515, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thành Viên";
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.btnFreeTicket);
            this.pnCustomer.Controls.Add(this.numericFreeTickets);
            this.pnCustomer.Controls.Add(this.lblCustomerName);
            this.pnCustomer.Controls.Add(this.lblPoint);
            this.pnCustomer.Controls.Add(this.lblPlusPoint);
            this.pnCustomer.Controls.Add(this.label6);
            this.pnCustomer.Controls.Add(this.label5);
            this.pnCustomer.Controls.Add(this.label4);
            this.pnCustomer.Controls.Add(this.label3);
            this.pnCustomer.Location = new System.Drawing.Point(16, 68);
            this.pnCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(487, 213);
            this.pnCustomer.TabIndex = 20;
            // 
            // btnFreeTicket
            // 
            this.btnFreeTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFreeTicket.Location = new System.Drawing.Point(347, 162);
            this.btnFreeTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFreeTicket.Name = "btnFreeTicket";
            this.btnFreeTicket.Size = new System.Drawing.Size(129, 44);
            this.btnFreeTicket.TabIndex = 10;
            this.btnFreeTicket.Text = "Đổi Vé";
            this.btnFreeTicket.UseVisualStyleBackColor = true;
            this.btnFreeTicket.Click += new System.EventHandler(this.btnFreeTicket_Click);
            // 
            // numericFreeTickets
            // 
            this.numericFreeTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericFreeTickets.Location = new System.Drawing.Point(253, 170);
            this.numericFreeTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericFreeTickets.Name = "numericFreeTickets";
            this.numericFreeTickets.Size = new System.Drawing.Size(67, 30);
            this.numericFreeTickets.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCustomerName.Location = new System.Drawing.Point(253, 14);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(181, 29);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "............................";
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.White;
            this.lblPoint.Location = new System.Drawing.Point(259, 62);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPoint.Multiline = true;
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(217, 38);
            this.lblPoint.TabIndex = 7;
            // 
            // lblPlusPoint
            // 
            this.lblPlusPoint.BackColor = System.Drawing.Color.White;
            this.lblPlusPoint.Location = new System.Drawing.Point(253, 121);
            this.lblPlusPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPlusPoint.Multiline = true;
            this.lblPlusPoint.Name = "lblPlusPoint";
            this.lblPlusPoint.Size = new System.Drawing.Size(223, 36);
            this.lblPlusPoint.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(25, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đổi vé miễn phí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm Cộng Thêm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm Tích Lũy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkCustomer.Location = new System.Drawing.Point(28, 34);
            this.chkCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(250, 29);
            this.chkCustomer.TabIndex = 0;
            this.chkCustomer.Text = "Khách Hàng Thành Viên";
            this.chkCustomer.UseVisualStyleBackColor = true;
            this.chkCustomer.CheckedChanged += new System.EventHandler(this.chkCustomer_CheckedChanged);
            // 
            // grpLoaiVe
            // 
            this.grpLoaiVe.BackColor = System.Drawing.Color.White;
            this.grpLoaiVe.Controls.Add(this.label2);
            this.grpLoaiVe.Controls.Add(this.lblTicketPrice);
            this.grpLoaiVe.Controls.Add(this.rdoChild);
            this.grpLoaiVe.Controls.Add(this.rdoStudent);
            this.grpLoaiVe.Controls.Add(this.rdoAdult);
            this.grpLoaiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpLoaiVe.ForeColor = System.Drawing.Color.Black;
            this.grpLoaiVe.Location = new System.Drawing.Point(20, 28);
            this.grpLoaiVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLoaiVe.Name = "grpLoaiVe";
            this.grpLoaiVe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLoaiVe.Size = new System.Drawing.Size(477, 287);
            this.grpLoaiVe.TabIndex = 0;
            this.grpLoaiVe.TabStop = false;
            this.grpLoaiVe.Text = "Loại Vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(40, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá Vé :";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Location = new System.Drawing.Point(205, 229);
            this.lblTicketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTicketPrice.Multiline = true;
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(253, 38);
            this.lblTicketPrice.TabIndex = 3;
            this.lblTicketPrice.TextChanged += new System.EventHandler(this.lblTicketPrice_TextChanged);
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoChild.Location = new System.Drawing.Point(53, 153);
            this.rdoChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(224, 29);
            this.rdoChild.TabIndex = 2;
            this.rdoChild.TabStop = true;
            this.rdoChild.Text = "Trẻ Em ( Dưới 12 tuổi)";
            this.rdoChild.UseVisualStyleBackColor = true;
            this.rdoChild.CheckedChanged += new System.EventHandler(this.rdoChild_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoStudent.Location = new System.Drawing.Point(244, 78);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(214, 29);
            this.rdoStudent.TabIndex = 1;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "Sinh Viên / Học Sinh";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoAdult.Location = new System.Drawing.Point(53, 79);
            this.rdoAdult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(122, 29);
            this.rdoAdult.TabIndex = 0;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Người Lớn";
            this.rdoAdult.UseVisualStyleBackColor = true;
            this.rdoAdult.CheckedChanged += new System.EventHandler(this.rdoAdult_CheckedChanged);
            // 
            // flpSeat
            // 
            this.flpSeat.BackColor = System.Drawing.Color.White;
            this.flpSeat.Location = new System.Drawing.Point(12, 203);
            this.flpSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(1057, 491);
            this.flpSeat.TabIndex = 2;
            this.flpSeat.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSeat_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(11, 110);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 89);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(340, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màn Hình Chiếu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.picFilm);
            this.panel3.Location = new System.Drawing.Point(1088, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 585);
            this.panel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(147, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Đang chọn (CÒN)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(147, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đã chọn (HẾT)";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(75, 542);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(75, 490);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // picFilm
            // 
            this.picFilm.Location = new System.Drawing.Point(52, 31);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(316, 434);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 0;
            this.picFilm.TabStop = false;
            this.picFilm.Click += new System.EventHandler(this.picFilm_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.grpLoaiVe);
            this.panel.Location = new System.Drawing.Point(15, 702);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(512, 332);
            this.panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(533, 704);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 329);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(1087, 705);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 329);
            this.panel5.TabIndex = 7;
            // 
            // btnthemkhachhang
            // 
            this.btnthemkhachhang.Location = new System.Drawing.Point(1115, 18);
            this.btnthemkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthemkhachhang.Name = "btnthemkhachhang";
            this.btnthemkhachhang.Size = new System.Drawing.Size(149, 49);
            this.btnthemkhachhang.TabIndex = 3;
            this.btnthemkhachhang.Text = "Thêm TV";
            this.btnthemkhachhang.UseVisualStyleBackColor = true;
            this.btnthemkhachhang.Click += new System.EventHandler(this.btnthemkhachhang_Click);
            // 
            // frmTheatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1533, 1044);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flpSeat);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmTheatre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁN VÉ";
            this.Load += new System.EventHandler(this.frmTheatre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnCustomer.ResumeLayout(false);
            this.pnCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeTickets)).EndInit();
            this.grpLoaiVe.ResumeLayout(false);
            this.grpLoaiVe.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpLoaiVe;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblTicketPrice;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox lblPoint;
        private System.Windows.Forms.TextBox lblPlusPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblDiscount;
        private System.Windows.Forms.TextBox lblPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnFreeTicket;
        private System.Windows.Forms.NumericUpDown numericFreeTickets;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bntquaylai;
        private System.Windows.Forms.Button btnthemkhachhang;
    }
}