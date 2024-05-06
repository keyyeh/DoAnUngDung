using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatPhong
    {
        private string maKS, sdt, maPhong;
        private DateTime ngayDatPhong, ngayTraPhong;

        public DTO_DatPhong(string maKS, string sdt, string maPhong, DateTime ngayDatPhong, DateTime ngayTraPhong)
        {
            this.MaKS = maKS;
            this.SDT = sdt;
            this.MaPhong = maPhong;
            this.NgayDatPhong = ngayDatPhong;
            this.NgayTraPhong = ngayTraPhong;
        }
        public DTO_DatPhong(string maKS, string maKH, string maPhong, DateTime ngayDatPhong)
        {
            this.MaKS = maKS;
            this.SDT = sdt;
            this.MaPhong = maPhong;
            this.NgayDatPhong = ngayDatPhong;
        }

        public string MaKS { get => maKS; set => maKS = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
    }
}
