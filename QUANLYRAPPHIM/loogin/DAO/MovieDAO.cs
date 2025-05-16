using loogin.DAO;
using loogin    .DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loogin.DAO
{
    public class MovieDAO
    {
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static List<Movie> GetListMovieByDate(DateTime date)
        {
            List<Movie> listMovie = new List<Movie>();

            // Kiểm tra xem có dữ liệu hay không
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM Phim WHERE NgayKetThuc >= @Date", new object[] { date });

            // Kiểm tra nếu data là null hoặc không có bản ghi nào
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    Movie movie = new Movie(row);
                    listMovie.Add(movie);
                }
            }
            else
            {
                // Nếu không có dữ liệu hoặc data là null, thông báo cho người dùng hoặc thực hiện xử lý khác
                Console.WriteLine("Không có phim cho ngày này. Vui lòng chọn ngày khác.");

                // Nếu muốn, bạn có thể chọn một ngày khác tự động, ví dụ như ngày hiện tại
                DateTime newDate = DateTime.Now;  // Ví dụ chọn ngày hiện tại
                Console.WriteLine("Chọn ngày mới: " + newDate.ToString("yyyy-MM-dd"));
                listMovie = GetListMovieByDate(newDate); // Gọi lại với ngày mới
            }

            return listMovie;
        }


        public static List<Movie> GetListMovie()
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM Phim");
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public static DataTable GetMovie()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetMovie");
        }

        public static bool InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }

        public static bool UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }

        public static bool DeleteMovie(string id)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + id + "'");
            DataProvider.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idPhim = '" + id + "'");

            MovieByGenreDAO.DeleteMovie_GenreByMovieID(id);
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.Phim WHERE id = '" + id + "'");
            return result > 0;
        }

        public static Movie GetMovieByID(string id)
        {
            Movie movie = null;
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Phim WHERE id = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }
    }
}
