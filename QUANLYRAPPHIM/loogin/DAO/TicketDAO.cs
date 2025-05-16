using loogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace loogin.DAO
{
    public class TicketDAO
    {
        public static List<Ticket> GetListTicketsByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "SELECT * FROM Ve WHERE idLichChieu = '" + showTimesID + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static List<Ticket> GetListTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "SELECT * FROM Ve WHERE idLichChieu = '" + showTimesID + "' AND TrangThai = 1";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int CountToltalTicketByShowTime(string showTimesID)
        {
            string query = "SELECT COUNT(id) FROM Ve WHERE idLichChieu = '" + showTimesID + "'";
            return (int)DataProvider.ExecuteScalar(query);
        }

        public static int CountTheNumberOfTicketsSoldByShowTime(string showTimesID)
        {
            string query = "SELECT COUNT(id) FROM Ve WHERE idLichChieu = '" + showTimesID + "' AND TrangThai = 1";
            return (int)DataProvider.ExecuteScalar(query);
        }

        // Vé không có thông tin khách hàng
        public static int BuyTicket(string ticketID, int type, float price)
        {
            string query = "UPDATE dbo.Ve SET TrangThai = 1, LoaiVe = " + type +
                           ", TienBanVe = " + price + " WHERE id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        // Vé có thông tin khách hàng
        public static int BuyTicket(string ticketID, int type, string customerID, float price)
        {
            string query = "UPDATE dbo.Ve SET TrangThai = 1, LoaiVe = " + type +
                           ", idKhachHang = N'" + customerID + "', TienBanVe = " + price +
                           " WHERE id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        // ✅ Vé có BookingID (không khách hàng)
        public static int BuyTicket(string ticketID, int type, float price, string bookingID)
        {
            string query = "UPDATE dbo.Ve SET TrangThai = 1, LoaiVe = " + type +
                           ", TienBanVe = " + price + ", BookingID = N'" + bookingID + "'" +
                           " WHERE id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        // ✅ Vé có BookingID + khách hàng
        public static int BuyTicket(string ticketID, int type, string customerID, float price, string bookingID)
        {
            string query = "UPDATE dbo.Ve SET TrangThai = 1, LoaiVe = " + type +
                           ", idKhachHang = N'" + customerID + "', TienBanVe = " + price +
                           ", BookingID = N'" + bookingID + "'" +
                           " WHERE id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        // ✅ Lấy danh sách vé theo BookingID
        public static List<Ticket> GetTicketsByBookingID(string bookingID)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "SELECT * FROM Ve WHERE BookingID = N'" + bookingID + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            string query = "USP_InsertTicketByShowTimes @idlichChieu , @maGheNgoi";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID, seatName });
        }

        public static int DeleteTicketsByShowTimes(string showTimesID)
        {
            string query = "USP_DeleteTicketsByShowTimes @idlichChieu";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID });
        }
    }
}
