using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loogin.DTO
{
    public class Customer
    {
        public Customer(string iD, string name, DateTime birth, string address,
            string phone, string identityCard, int point)
        {
            this.ID = iD;
            this.Name = name;
            this.BirthDate = birth;
            this.Address = address;
            this.Phone = phone;
            this.IdentityCard = identityCard;
            this.Point = point;
        }

        public Customer(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["HoTen"].ToString();
            DateTime birth;
            DateTime.TryParse(row["NgaySinh"].ToString(), out birth);
            this.BirthDate = birth;
            this.Address = row["DiaChi"].ToString();
            this.Phone = row["SDT"].ToString();

            // Nếu NULL thì trả về chuỗi rỗng
            this.IdentityCard = row["CMND"] == DBNull.Value ? "" : row["CMND"].ToString();

            // Nếu NULL thì trả về 0
            this.Point = row["DiemTichLuy"] == DBNull.Value ? 0 : Convert.ToInt32(row["DiemTichLuy"]);
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string IdentityCard { get; set; }
        public int Point { get; set; }
    }
}
