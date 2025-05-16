
using System;
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loogin.DAO;
using loogin.DTO;

namespace loogin
{
    public partial class frmTheatre: Form
    {
        

        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế

        List<Ticket> listSeat = new List<Ticket>();
        Button currentSelectedSeat = null; // lưu ghế đang chọn để gán loại vé

        //dùng lưu vết các Ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0;//Hiện thị giá vé
        float ticketPrice = 0;//Lưu giá vé gốc
        float total = 0;//Tổng giá tiền
        float discount = 0;//Tiền được giảm
        float payment = 0;//Tiền phải trả
        int plusPoint = 0;//Số điểm tích lũy khi mua vé

        Customer customer;//lưu lại khách hàng thành viên

        ShowTimes Times;
        Movie Movie;
        public frmTheatre(ShowTimes showTimes, Movie movie)
        {
            InitializeComponent();
            Times = showTimes;
            Movie = movie;
        }

        private void frmTheatre_Load(object sender, EventArgs e)
        {
            ticketPrice = Times.TicketPrice;

            lblInformation.Text = "CGV GT3D| NIIE | " + Times.CinemaName + " | " + Times.MovieName;
            lblTime.Text = Times.Time.ToShortDateString() + " | "
                + Times.Time.ToShortTimeString() + " - "
                + Times.Time.AddMinutes(Movie.Time).ToShortTimeString();
            if (Movie.Poster != null)
                picFilm.Image = MovieDAO.byteArrayToImage(Movie.Poster);

            rdoAdult.Checked = true;
            chkCustomer.Enabled = false;
            grpLoaiVe.Enabled = false;

            LoadDataCinema(Times.CinemaName);

            ShowOrHideLablePoint();

            listSeat = TicketDAO.GetListTicketsByShowTimes(Times.ID);

            LoadSeats(listSeat);
        }
        private void LoadDataCinema(string cinemaName)
        {
            Cinema cinema = CinemaDAO.GetCinemaByName(cinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            flpSeat.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }


        private void LoadBill()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            lblTicketPrice.Text = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }


        private void LoadSeats(List<Ticket> list)
        {
            flpSeat.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = SIZE + 20, Height = SIZE };
                btnSeat.Text = list[i].SeatName;
                if (list[i].Status == 1)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);

                btnSeat.Tag = list[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;

            if (btnSeat.BackColor == Color.White)
            {
                // Ghế mới được chọn
                btnSeat.BackColor = Color.Yellow;
                Ticket ticket = btnSeat.Tag as Ticket;

                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total += ticketPrice;
                payment = total - discount;
                ticket.Type = 1; // Mặc định là người lớn

                listSeatSelected.Add(btnSeat);
                currentSelectedSeat = btnSeat; // 👉 Lưu lại ghế đang được chọn

                plusPoint++;
                lblPlusPoint.Text = plusPoint + "";
                grpLoaiVe.Enabled = true;
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                // Bỏ chọn ghế
                btnSeat.BackColor = Color.White;
                Ticket ticket = btnSeat.Tag as Ticket;

                total -= ticket.Price;
                payment = total - discount;
                ticket.Price = 0;
                displayPrice = ticket.Price;
                ticket.Type = 0;

                listSeatSelected.Remove(btnSeat);
                if (currentSelectedSeat == btnSeat)
                    currentSelectedSeat = null;

                plusPoint--;
                lblPlusPoint.Text = plusPoint + "";

                grpLoaiVe.Enabled = listSeatSelected.Count > 0;
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }

            LoadBill();
            chkCustomer.Enabled = listSeatSelected.Count > 0;
        }

        //dùng để ẩn hiện lable điểm tích lũy của khách hàng thành viên
        private void ShowOrHideLablePoint()
        {
            if (chkCustomer.Checked == true)
            {
                pnCustomer.Visible = true;
            }
            else
            {
                pnCustomer.Visible = false;
            }
        }

        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            chkCustomer.Checked = false;
            chkCustomer.Enabled = false;

            ShowOrHideLablePoint();

            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
            plusPoint = 0;

            LoadBill();
        }








        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko?",
                "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }

            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông?";

            DialogResult result = MessageBox.Show(message, "Hỏi Mua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int ret = 0;

                // 👉 Tạo BookingID phân biệt mua lẻ / nhiều
                string bookingPrefix = listSeatSelected.Count > 1 ? "MUACUNG-" : "MUALE-";
                string bookingID = bookingPrefix + Guid.NewGuid().ToString().Substring(0, 8);

                if (chkCustomer.Checked)
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;
                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, customer.ID, ticket.Price, bookingID);
                    }
                    customer.Point += plusPoint;
                    CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point);
                }
                else
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;
                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, ticket.Price, bookingID);
                    }
                }

                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");

                    List<Ticket> listTicketBought = TicketDAO.GetTicketsByBookingID(bookingID);
                    ExportTicketToFile(listTicketBought);
                }
            }

            RestoreDefault();
            this.OnLoad(new EventArgs());
        }
        private void ExportTicketToFile(List<Ticket> tickets)
        {
            // Tạo thư mục lưu vé nếu chưa có
            string folderPath = Path.Combine(Application.StartupPath, "Tickets");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Làm sạch tên phim để không chứa ký tự không hợp lệ trong tên file
            string safeMovieName = string.Join("_", Movie.Name.Split(Path.GetInvalidFileNameChars()));
            string timeStr = Times.Time.ToString("yyyyMMdd_HHmm");
            string fileName = $"Ve_{safeMovieName}_{timeStr}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("======== VÉ XEM PHIM ========");
                writer.WriteLine($"Phim       : {Times.MovieName}");
                writer.WriteLine($"Rạp        : {Times.CinemaName}");
                writer.WriteLine($"Suất chiếu : {Times.Time:dd/MM/yyyy HH:mm}");

                if (customer != null)
                {
                    writer.WriteLine($"Khách hàng : {customer.Name}");
                    writer.WriteLine($"Điểm còn lại: {customer.Point}");
                }

                writer.WriteLine("Ghế đã mua:");
                foreach (Ticket ticket in tickets)
                {
                    writer.WriteLine($" - {ticket.SeatName} | Giá: {ticket.Price:N0} đ");
                }

                writer.WriteLine("-----------------------------");
                writer.WriteLine($"Tổng tiền : {total:N0} đ");
                writer.WriteLine($"Giảm giá  : {discount:N0} đ");
                writer.WriteLine($"Phải trả  : {payment:N0} đ");
                writer.WriteLine("=============================");
                writer.WriteLine("Cảm ơn bạn đã mua vé tại CGV G2TD!");
                writer.WriteLine("Chúc bạn xem phim vui vẻ :))");
            }

            MessageBox.Show($"Đã lưu vé vào file:\n{filePath}", "Xuất Vé Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStudent.Checked && currentSelectedSeat != null)
            {
                Ticket ticket = currentSelectedSeat.Tag as Ticket;
                ticket.Type = 2;

                float oldPrice = ticket.Price;
                ticket.Price = 0.8f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }


        private void rdoAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAdult.Checked && currentSelectedSeat != null)
            {
                Ticket ticket = currentSelectedSeat.Tag as Ticket;
                ticket.Type = 1;

                float oldPrice = ticket.Price;
                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoChild_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChild.Checked && currentSelectedSeat != null)
            {
                Ticket ticket = currentSelectedSeat.Tag as Ticket;
                ticket.Type = 3;

                float oldPrice = ticket.Price;
                ticket.Price = 0.7f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }


        private void chkCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                frmCustomer frm = new frmCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customer = frm.customer;
                    lblCustomerName.Text = customer.Name;
                    lblPoint.Text = customer.Point + "";
                    ShowOrHideLablePoint();
                }
                else
                {
                    chkCustomer.Checked = false;
                }
            }
            else
            {
                ShowOrHideLablePoint();
                customer = null;
            }
        }

        private void btnFreeTicket_Click(object sender, EventArgs e)
        {
            int freeTickets = (int)numericFreeTickets.Value;
            if (freeTickets <= 0) return;

            if (freeTickets > listSeat.Count)
            {
                MessageBox.Show("BẠN CHỈ ĐỔI ĐƯỢC TỐT ĐA [" + listSeatSelected.Count + "] VÉ", "THÔNG BÁO");
                return;
            }
            int pointFreeTicket = freeTickets * 20;
            if (customer.Point < pointFreeTicket)
            {
                MessageBox.Show("BẠN KHÔNG ĐỦ ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ", "THÔNG BÁO");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN DÙNG ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ MIỄN PHÍ KHÔNG?",
                                        "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customer.Point -= pointFreeTicket;
                    plusPoint -= freeTickets;

                    if (CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point))
                    {
                        MessageBox.Show("BẠN ĐÃ DỔI ĐƯỢC [" + freeTickets + "] VÉ MIỄN PHÍ THÀNH CÔNG", "THÔNG BÁO");
                    }
                    lblPoint.Text = "" + customer.Point;
                    lblPlusPoint.Text = "" + plusPoint;

                    for (int i = 0; i < listSeatSelected.Count && freeTickets > 0; i++)
                    {
                        Ticket ticket = listSeatSelected[i].Tag as Ticket;
                        if (ticket.Price != 0)
                        {
                            discount += ticket.Price;
                            ticket.Price = 0;
                            freeTickets--;
                        }
                    }

                    payment = total - discount;
                    LoadBill();
                }
            }
        }

        private void lblTicketPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInformation_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                frmCustomer frm = new frmCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customer = frm.customer;
                    lblCustomerName.Text = customer.Name;
                    lblPoint.Text = customer.Point + "";
                    ShowOrHideLablePoint();
                }
                else
                {
                    chkCustomer.Checked = false;
                }
            }
            else
            {
                ShowOrHideLablePoint();
                customer = null;
            }
        }

        private void picFilm_Click(object sender, EventArgs e)
        {

        }

        private void bntquaylai_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn frmTheatre
            MainFormnv login = new MainFormnv();
            login.ShowDialog(); // Hiển thị LoginForm (chặn đến khi đóng)
            this.Close(); // Đóng hẳn MainForm sau khi đăng xuất
        }

        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            formThemkhachhang frm = new formThemkhachhang();
            frm.ShowDialog();
        }
    }
}
