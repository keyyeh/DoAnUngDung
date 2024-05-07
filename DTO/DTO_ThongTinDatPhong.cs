using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DTO_ThongTinDatPhong
    {
        private string maKS, tenKS, tenKH, sdt;
        private DateTime ngayDatPhong, ngayTraPhong;
        private double tongTien;

        public DTO_ThongTinDatPhong()
        {

        }
        public DTO_ThongTinDatPhong(string maKS, string tenKS, string tenKH, string sdt, DateTime ngayDatPhong, DateTime ngayTraPhong, double tongTien)
        {
            this.maKS = maKS;
            this.tenKS = tenKS;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.ngayDatPhong = ngayDatPhong;
            this.ngayTraPhong = ngayTraPhong;
            this.tongTien = tongTien;
        }

        public double TongTien { get => tongTien; set => tongTien = value; }
        public string MaKS { get => maKS; set => maKS = value; }
        public string TenKS { get => tenKS; set => tenKS = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
    }
}
