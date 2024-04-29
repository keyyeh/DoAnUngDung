using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KhachHang
    {

        public IQueryable Xem()
        {
            var KhachHang = from KH in ConectionData.dt.KHACHHANGs
                            select KH;
            return KhachHang;
        }
        public int Them(DTO_KhachHang kh)
        {
            try
            {
                KHACHHANG khachHang = new KHACHHANG
                {
                    MAKH = kh.MaKH,
                    TENKH = kh.TenKH,
                    CMND = kh.CMND,
                    GIOITINH = kh.GioiTinh,
                    DIACHI = kh.DiaChi,
                    EMAIL = kh.Email,
                    SDT = kh.Sdt,
                };
                ConectionData.dt.KHACHHANGs.InsertOnSubmit(khachHang);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }
        public void Sua(DTO_KhachHang kh)
        {
            var sua = ConectionData.dt.KHACHHANGs.Single(khachHang => khachHang.MAKH == kh.MaKH);
            sua.TENKH = kh.TenKH;
            sua.CMND = kh.CMND;
            sua.GIOITINH = kh.GioiTinh;
            sua.DIACHI = kh.DiaChi;
            sua.EMAIL = kh.Email;
            sua.SDT = kh.Sdt;

            ConectionData.dt.KHACHHANGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string maKH)
        {
            var xoa = from kh in ConectionData.dt.KHACHHANGs
                      where kh.MAKH == maKH
                      select kh;
            foreach (var item in xoa)
            {
                ConectionData.dt.KHACHHANGs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }

    }
}
