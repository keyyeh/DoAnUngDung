using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string maNV, maKS, maChucVu, hoNV, tenNV, sdt, diaChi;
        private DateTime ngaySinh;
        private byte[] image;

        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string maNV, string maKS, string maChucVu, string hoNV, string tenNV, string sdt, string diaChi, DateTime ngaySinh, byte[] image)
        {
            this.MaNV = maNV;
            this.MaKS = maKS;
            this.MaChucVu = maChucVu;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.Image = image;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKS { get => maKS; set => maKS = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}
