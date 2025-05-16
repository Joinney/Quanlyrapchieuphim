using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loogin
{
    public partial class formThemkhachhang: Form
    {
        public formThemkhachhang()
        {
            InitializeComponent();
        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string makh = txtmakh.Text;
            string hoten = txthoten.Text;
            DateTime ngaysinh = dateTime.Value;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;

            int cmnd;
            if (!int.TryParse(txtcmnd.Text, out cmnd))
            {
                MessageBox.Show("CMND phải là số hợp lệ!");
                return;
            }

            int diem = 0;

            using (SqlConnection conn = Config.GetConnection())
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM KhachHang WHERE CMND = @cmnd";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@cmnd", cmnd);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Khách hàng với CMND này đã tồn tại!");
                    return;
                }

                string insertQuery = "INSERT INTO KhachHang (id, HoTen, NgaySinh, DiaChi, SDT, CMND, DiemTichLuy) " +
                                     "VALUES (@id, @hoten, @ngaysinh, @diachi, @sdt, @cmnd, @diem)";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@id", makh);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@cmnd", cmnd);
                cmd.Parameters.AddWithValue("@diem", diem);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
            }
        }
    }
}
