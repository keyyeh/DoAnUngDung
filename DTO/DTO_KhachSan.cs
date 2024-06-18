using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachSan
    {
        private string maKS, tenKS, diaDiem, danhGia, sDT;

        public DTO_KhachSan()
        {

        }
        public DTO_KhachSan(string maKS, string tenKS, string diaDiem, string danhGia, string sDT)
        {
            this.maKS = maKS;
            this.tenKS = tenKS;
            this.diaDiem = diaDiem;
            this.danhGia = danhGia;
            this.sDT = sDT;
        }

        public string MaKS { get => maKS; set => maKS = value; }
        public string TenKS { get => tenKS; set => tenKS = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
