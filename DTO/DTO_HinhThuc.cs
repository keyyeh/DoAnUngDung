using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HinhThuc
    {
        private int maHT;
        private string tenHT;
        private double gia;

        public DTO_HinhThuc(int maHT, string tenHT, double gia)
        {
            this.maHT = maHT;
            this.tenHT = tenHT;
            this.gia = gia;
        }

        public int MaHT { get => maHT; set => maHT = value; }
        public string TenHT { get => tenHT; set => tenHT = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
