using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiPhong
    {
        private int maLoaiP;
        private string tenLoaiP;
        private double gia;

        public DTO_LoaiPhong()
        {

        }
       
        public DTO_LoaiPhong(int maLoaiP, string tenLoaiP, double gia)
        {
            this.maLoaiP = maLoaiP;
            this.tenLoaiP = tenLoaiP;
            this.gia = gia;
        }

        public int MaLoaiP { get => maLoaiP; set => maLoaiP = value; }
        public string TenLoaiP { get => tenLoaiP; set => tenLoaiP = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
