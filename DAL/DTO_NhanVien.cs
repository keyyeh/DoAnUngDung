using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        public IQueryable Xem()
        {
            var nhanVien = from NV in ConectionData.dt.NHANVIENs
                           select NV;
            return nhanVien;
        }
        public void Them(DTO_NhanVien nv)
        {
            try
            {
                NHANVIEN nhanVien = new NHANVIEN
                {
                    MANV = nv.MaNV,
                    MAKS = nv.MaKS,
                    MACHUCVU = nv.MaChucVu,
                    HINHANH = nv.Image,
                    HONV = nv.HoNV,
                    TENNV = nv.TenNV,
                    NGAYSINH = nv.NgaySinh,
                    SDT = nv.Sdt,
                    DIACHI = nv.DiaChi,
                };
                ConectionData.dt.NHANVIENs.InsertOnSubmit(nhanVien);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
        }
        public void Sua(DTO_NhanVien nv)
        {
            var sua = ConectionData.dt.NHANVIENs.Single(nhanVien => nhanVien.MANV == nv.MaNV);
            sua.MAKS = nv.MaKS;
            sua.MACHUCVU = nv.MaChucVu;
            sua.HINHANH = nv.Image;
            sua.HONV = nv.HoNV;
            sua.TENNV = nv.TenNV;
            sua.NGAYSINH = nv.NgaySinh;
            sua.SDT = nv.Sdt;
            sua.DIACHI = nv.DiaChi;

            ConectionData.dt.NHANVIENs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string maNV)
        {
            var xoa = from NV in ConectionData.dt.NHANVIENs
                      where NV.MANV == maNV
                      select NV;
            foreach (var item in xoa)
            {
                ConectionData.dt.NHANVIENs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }
    }
}
