using System.Windows.Forms;

namespace loogin.btnTaikhoan
{
    partial class AccountUC
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
            this.components = new System.ComponentModel.Container();
            this.toolTipAccountType = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.cboStaffID_Account = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStaffName_Account = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnInsertAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 73);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 568);
            this.panel2.TabIndex = 38;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(28, 16);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.Size = new System.Drawing.Size(1077, 330);
            this.dtgvAccount.TabIndex = 24;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.btnInsertAccount);
            this.panel4.Controls.Add(this.btnShowAccount);
            this.panel4.Controls.Add(this.btnDeleteAccount);
            this.panel4.Controls.Add(this.btnUpdateAccount);
            this.panel4.Location = new System.Drawing.Point(3, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1353, 79);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.Controls.Add(this.dtgvAccount);
            this.panel5.Location = new System.Drawing.Point(115, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1135, 365);
            this.panel5.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Location = new System.Drawing.Point(1256, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 568);
            this.panel3.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnResetPass);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.grpAccount);
            this.panel7.Location = new System.Drawing.Point(15, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1106, 163);
            this.panel7.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(115, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1135, 196);
            this.panel6.TabIndex = 42;
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.cboStaffID_Account);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.txtStaffName_Account);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(22, 15);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Size = new System.Drawing.Size(587, 133);
            this.grpAccount.TabIndex = 39;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản";
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(416, 36);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(141, 30);
            this.nudAccountType.TabIndex = 6;
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboStaffID_Account
            // 
            this.cboStaffID_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffID_Account.FormattingEnabled = true;
            this.cboStaffID_Account.Location = new System.Drawing.Point(137, 82);
            this.cboStaffID_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStaffID_Account.Name = "cboStaffID_Account";
            this.cboStaffID_Account.Size = new System.Drawing.Size(147, 30);
            this.cboStaffID_Account.TabIndex = 5;
            this.cboStaffID_Account.SelectedIndexChanged += new System.EventHandler(this.cboStaffID_Account_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(137, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtStaffName_Account
            // 
            this.txtStaffName_Account.BackColor = System.Drawing.Color.White;
            this.txtStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName_Account.Location = new System.Drawing.Point(416, 82);
            this.txtStaffName_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName_Account.Name = "txtStaffName_Account";
            this.txtStaffName_Account.ReadOnly = true;
            this.txtStaffName_Account.Size = new System.Drawing.Size(141, 30);
            this.txtStaffName_Account.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName_Account.Location = new System.Drawing.Point(321, 85);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(80, 23);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Tên NV:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(321, 39);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(87, 23);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại TK:";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(24, 85);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchAccount);
            this.groupBox1.Controls.Add(this.btnSearchAccount);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(650, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(209, 68);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo tên";
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(29, 25);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(132, 30);
            this.txtSearchAccount.TabIndex = 18;
            this.txtSearchAccount.KeyDown += new KeyEventHandler(this.txtSearchAccount_TextChanged);

            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAccount.Location = new System.Drawing.Point(168, 25);
            this.btnSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(27, 26);
            this.btnSearchAccount.TabIndex = 19;
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(944, 66);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(117, 55);
            this.btnResetPass.TabIndex = 46;
            this.btnResetPass.Text = "Reset mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.Location = new System.Drawing.Point(198, 17);
            this.btnInsertAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(109, 44);
            this.btnInsertAccount.TabIndex = 47;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.UseVisualStyleBackColor = true;
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(1109, 17);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(108, 44);
            this.btnShowAccount.TabIndex = 44;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(526, 17);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(117, 44);
            this.btnDeleteAccount.TabIndex = 45;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(796, 17);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(113, 44);
            this.btnUpdateAccount.TabIndex = 46;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1359, 738);
            this.Load += new System.EventHandler(this.AccountUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipAccountType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.ComboBox cboStaffID_Account;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffName_Account;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnInsertAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
    }
}