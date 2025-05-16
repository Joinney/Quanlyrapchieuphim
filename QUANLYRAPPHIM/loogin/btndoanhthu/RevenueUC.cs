using loogin.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loogin.btndoanhthu
{
    public partial class RevenueUC: UserControl
    {
        public RevenueUC()
        {
            InitializeComponent();
            LoadRevenue();
        }
        void LoadRevenue()
        {
            LoadMovieIntoCombobox(cboSelectMovie);
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }
        void LoadMovieIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = MovieDAO.GetListMovie();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
        }
        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = RevenueDAO.GetRevenue(idMovie, fromDate, toDate);
            txtDoanhThu.Text = GetSumRevenue().ToString("c", culture);
            LoadChart(); // thêm dòng này
        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }
        private void RevenueUC_Load(object sender, EventArgs e)
        {

        }

        private void dtgvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }

        private void btnReportRevenue_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
            frm.ShowDialog();
        }
        void LoadChart()
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();
            chartRevenue.ChartAreas.Add("ChartArea1");

            // Series cho Doanh thu
            var revenueSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu");
            revenueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            revenueSeries.Color = Color.OrangeRed;

            // Series cho Số vé
            var ticketSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Số vé");
            ticketSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            ticketSeries.Color = Color.SteelBlue;
            ticketSeries.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary; // Đặt trục Y thứ hai cho Số vé

            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                if (row.Cells["Ngày chiếu"].Value != null && row.Cells["Tiền vé"].Value != null && row.Cells["Số vé đã bán"].Value != null)
                {
                    string date = Convert.ToDateTime(row.Cells["Ngày chiếu"].Value).ToString("dd/MM");
                    decimal revenue = Convert.ToDecimal(row.Cells["Tiền vé"].Value);
                    int ticketCount = Convert.ToInt32(row.Cells["Số vé đã bán"].Value); // Thay đổi tên cột nếu cần

                    // Thêm dữ liệu vào Series "Doanh thu"
                    revenueSeries.Points.AddXY(date, revenue);

                    // Thêm dữ liệu vào Series "Số vé"
                    ticketSeries.Points.AddXY(date, ticketCount);
                }
            }

            // Thêm cả hai Series vào Chart
            chartRevenue.Series.Add(revenueSeries);
            chartRevenue.Series.Add(ticketSeries);

            // Thiết lập tiêu đề cho trục
            chartRevenue.ChartAreas[0].AxisX.Title = "Ngày chiếu";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartRevenue.ChartAreas[0].AxisY2.Title = "Số vé"; // Trục Y thứ hai cho Số vé
            chartRevenue.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True; // Kích hoạt trục Y thứ hai
        }


    }
}
