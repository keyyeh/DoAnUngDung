using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string maKH, tenKH, cMND, diaChi, email, sdt;
        private bool gioiTinh;

        public DTO_KhachHang(string maKH, string tenKH, string cMND, bool gioiTinh, string diaChi, string email, string sdt)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.CMND = cMND;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Email = email;
            this.Sdt = sdt;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
