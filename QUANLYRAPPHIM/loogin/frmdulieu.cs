using loogin.btnDulieu;
using loogin.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loogin
{
    public partial class frmdulieu : Form
    {
        public frmdulieu()
        {
            InitializeComponent();
        }



        private void btnScreenTypeUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            ScreenTypeUC screenTypeUC = new ScreenTypeUC();
            screenTypeUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(screenTypeUC);
        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            CinemaUC cinemaUC = new CinemaUC();
            cinemaUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(cinemaUC);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            GenreUC genreUc = new GenreUC();
            genreUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(genreUc);
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();
            MovieUC movieUc = new MovieUC();
            movieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(movieUc);
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            FormatMovieUC formatMovieUc = new FormatMovieUC();
            formatMovieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(formatMovieUc);
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();

            // Gọi đúng namespace và class
             loogin.btnDulieu.TicketsUC ticketsUc = new loogin.btnDulieu.TicketsUC();
                ticketsUc.Dock = DockStyle.Fill;
                pnData.Controls.Add(ticketsUc);
        }

        private void pnData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
