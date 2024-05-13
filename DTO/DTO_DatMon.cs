using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatMon
    {
        private int maSP;
        private string maPhong;
        private double tongTien;

        public DTO_DatMon(int maSP, string maPhong, double tongTien)
        {
            this.maSP = maSP;
            this.maPhong = maPhong;
            this.tongTien = tongTien;
        }

        public int MaSP { get => maSP; set => maSP = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
