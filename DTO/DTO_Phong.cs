using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phong
    {
        private string maPhong, maKS, maTang,tenPhong,loaiPhong;
        private double gia;
        private int sucChua;

        public DTO_Phong()
        {
        }
        public DTO_Phong(string maPhong, string maKS, string maTang,string tenPhong,string loaiPhong, double gia, int sucChua)
        {
            this.MaPhong = maPhong;
            this.MaKS = maKS;
            this.MaTang = maTang;
            this.TenPhong = tenPhong;
            this.LoaiPhong = loaiPhong;
            this.Gia = gia;
            this.SucChua = sucChua;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaKS { get => maKS; set => maKS = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public double Gia { get => gia; set => gia = value; }
        public int SucChua { get => sucChua; set => sucChua = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaTang { get => maTang; set => maTang = value; }
    }
}
