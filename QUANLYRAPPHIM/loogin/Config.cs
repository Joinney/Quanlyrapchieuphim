using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loogin
{
    public static class Config
    {
        // 🔹 CHUỖI KẾT NỐI SQL SERVER (CẬP NHẬT THEO CẤU HÌNH CỦA BẠN)
        private static readonly string connectionString = "Data Source=LAPTOP-VDT;Initial Catalog=QLRP;Integrated Security=True;TrustServerCertificate=True";

        // Nếu bạn dùng tài khoản SQL, hãy dùng chuỗi này:
        // private static readonly string connectionString = "Data Source=LAPTOP-IPKKDPIQ;Initial Catalog=QLRP;User ID=sa;Password=yourpassword;TrustServerCertificate=True";

        /// <summary>
        /// Lấy kết nối SQL Server
        /// </summary>
        /// <returns>SqlConnection</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open(); // Thử mở kết nối
                conn.Close(); // Đóng ngay để tránh lỗi giữ kết nối
                return new SqlConnection(connectionString); // Trả về kết nối mới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến SQL Server!\nLỗi: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Trả về null nếu có lỗi
            }
        }
    }
}
