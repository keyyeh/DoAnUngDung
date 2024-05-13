using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MucSP
    {
        private string tenSp;
        private int soLuong;
        private double thanhTien;
        private double gia;

        public DTO_MucSP(string tenSp, int soLuong, double thanhTien, double gia)
        {
            this.tenSp = tenSp;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.gia = gia;
        }

        public string TenSp { get => tenSp; set => tenSp = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double Gia { get => gia; set => gia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
