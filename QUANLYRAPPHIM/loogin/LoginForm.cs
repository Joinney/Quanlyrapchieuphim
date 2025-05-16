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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loogin
{
    public partial class LoginForm : Form
    {
        
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public LoginForm()
        {
            InitializeComponent();
            location[0] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_1.jpg";
            location[1] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_2.jpg";
            location[2] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_4.jpg";
            location[3] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_5.jpg";
            location[4] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_6.jpg";
            location[5] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_7.jpg";
            location[6] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_8.jpg";
            location[7] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_9.jpg";
            location[8] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_10.jpg";
            location[9] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_11.jpg";
            location[10] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_12.jpg";
            location[11] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_13.jpg";
            location[12] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_14.jpg";
            location[13] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_15.jpg";
            location[14] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_16.jpg";
            location[15] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_17.jpg";
            location[16] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_18.jpg";
            location[17] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_19.jpg";
            location[18] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_20.jpg";
            location[19] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_21.jpg";
            location[20] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_22.jpg";
            location[21] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_23.jpg";
            location[22] = @"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_24.jpg";
            tounage();
           
        }

        private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_user_24.jpg"));


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0 && txtusername.Text.Length <= 15)
            {
                pictureBox2.Image = images[txtusername.Text.Length - 1];
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtusername.Text.Length <= 0)
                pictureBox2.Image = Properties.Resources.debut;
            else
                pictureBox2.Image = images[22];
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                // Nếu mật khẩu đang hiển thị, sử dụng ảnh textbox mở
                pictureBox2.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_passwordshow.png");
            }
            else
            {
                // Nếu mật khẩu đang ẩn, sử dụng ảnh textbox đóng
                pictureBox2.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_password.png");
            }
        }

        private void dangnhapclick_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Config.GetConnection()) // Lấy kết nối từ Config.cs
            {
                try
                {
                    conn.Open();

                    string query = "SELECT LoaiTK FROM TaiKhoan WHERE UserName=@username AND Pass=@password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int loaiTK = Convert.ToInt32(result);

                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide(); // Ẩn form đăng nhập

                            if (loaiTK == 1)
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.ShowDialog();
                            }
                            else if (loaiTK == 2)
                            {
                                MainFormnv mainFormnv = new MainFormnv();
                                mainFormnv.ShowDialog();
                            }

                            this.Show(); // Hiển thị lại form đăng nhập sau khi đóng form chính
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        // Biến theo dõi trạng thái hiển thị mật khẩu
        private bool isPasswordVisible = false;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '●'; // Mật khẩu bị ẩn mặc định
            pictureyes.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\photo\eye_closed.png"); // Icon mắt đóng
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái hiển thị mật khẩu
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtpassword.PasswordChar = '\0'; // Hiển thị mật khẩu
                pictureyes.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\photo\eye_open.png"); // Icon mắt mở
                pictureBox2.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_passwordshow.png"); // Ảnh textbox khi mở mật khẩu
            }
            else
            {
                txtpassword.PasswordChar = '●'; // Ẩn mật khẩu dưới dạng dấu chấm
                pictureyes.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\photo\eye_closed.png"); // Icon mắt đóng
                pictureBox2.Image = new Bitmap(@"D:\WinForm C#\QUANLYRAPPHIM\loogin\animation\textbox_password.png"); // Ảnh textbox khi ẩn mật khẩu
            }
        }

    }
}