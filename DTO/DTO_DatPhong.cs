using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatPhong
    {
        private string maHD, sdt;
        private DateTime ngayDatPhong, ngayTraPhong;
        private double tongTien;
        private int maSP, maPhong;

        public DTO_DatPhong(string maHD, string sdt, int maPhong, int maSP,DateTime ngayDatPhong, DateTime ngayTraPhong,double tongTien)
        {
            this.maHD = maHD;
            this.SDT = sdt;
            this.MaPhong = maPhong;
            this.maSP = maSP;
            this.NgayDatPhong = ngayDatPhong;
            this.NgayTraPhong = ngayTraPhong;
            this.TongTien = tongTien;
        }
        public DTO_DatPhong(string maHD, string sdt, int maPhong, DateTime ngayDatPhong)
        {
            this.MaHD = maHD;
            this.SDT = sdt;
            this.MaPhong = maPhong;
            this.NgayDatPhong = ngayDatPhong;
        }
        public DTO_DatPhong(int maPhong,DateTime ngayDatPhong,DateTime ngayTraPhong,double tongTien)
        { 
            this.MaPhong = maPhong;
            this.NgayDatPhong = ngayDatPhong;
            this.NgayTraPhong = ngayTraPhong;
            this.TongTien = tongTien;
        }
        public DTO_DatPhong()
        {

        }

        public string SDT { get => sdt; set => sdt = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public string MaHD { get => maHD; set => maHD = value; }
    }
}
