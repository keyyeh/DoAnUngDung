using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        private int maSP,maLoai;
        private string tenSP,donVi;
        private double gia;

        public DTO_SanPham(int maSP, int maLoai, string tenSP, string donVi, double gia)
        {
            this.maSP = maSP;
            this.maLoai = maLoai;
            this.tenSP = tenSP;
            this.donVi = donVi;
            this.gia = gia;
        }
        public DTO_SanPham(int maSP, string tenSP, string donVi, double gia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donVi = donVi;
            this.gia = gia;
        }
        public DTO_SanPham()
        {

        }

        public int MaSP { get => maSP; set => maSP = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
