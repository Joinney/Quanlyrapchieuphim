using loogin.btndoanhthu;
using loogin.btnkhachhang;
using loogin.btnNhanvien;
using loogin.btnTaikhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loogin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            // Kiểm tra nếu đã có 1 form trong CenterPanel thì không tạo thêm mới
            if (CenterPanel.Controls.Count > 0)
            {
                Form currentForm = CenterPanel.Controls[0] as Form;
                if (currentForm != null && currentForm.GetType() == f.GetType())
                {
                    return; // Nếu form đang mở là cùng loại, không làm gì cả
                }

                CenterPanel.Controls.Clear(); // Xóa form cũ nếu khác loại
            }

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            CenterPanel.Controls.Add(f);
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            AddControls(new frmdulieu());

        }

        private void CenterPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn MainForm
            LoginForm login = new LoginForm();
            login.ShowDialog(); // Hiển thị LoginForm (chặn đến khi đóng)
            this.Close(); // Đóng hẳn MainForm sau khi đăng xuất
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void wellcom_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();  // Xóa tất cả controls hiện tại
            this.InitializeComponent(); // Load lại giao diện ban đầu
        }

        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            this.Text = "Nhân Viên";
            CenterPanel.Controls.Clear();
            StaffUC staffUc = new StaffUC();
            staffUc.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(staffUc);
        }

        private void btnCustomerUC_Click(object sender, EventArgs e)
        {
            this.Text = "Khách Hàng";
            CenterPanel.Controls.Clear();
            CustomerUC customerUc = new CustomerUC();
            customerUc.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(customerUc);
        }

        private void btnRevenueUC_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh Thu";
            CenterPanel.Controls.Clear();
            RevenueUC revenueUc = new RevenueUC();
            revenueUc.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(revenueUc);
        }

        private void btnAccountUC_Click(object sender, EventArgs e)
        {
            this.Text = "Tài Khoản";
            CenterPanel.Controls.Clear();
            AccountUC accountUc = new AccountUC();
            accountUc.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(accountUc);
        }
    }
}
