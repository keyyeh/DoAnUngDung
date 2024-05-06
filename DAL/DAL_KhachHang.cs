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

        public IQueryable Xem(string sdt)
        {
            var KhachHang = from KH in ConectionData.dt.KHACHHANGs
                            where KH.SDT == sdt
                            select KH;
            return KhachHang;
        }
        public int Them(DTO_KhachHang kh)
        {
            try
            {
                KHACHHANG khachHang = new KHACHHANG
                {
                    SDT = kh.Sdt,
                    TENKH = kh.TenKH,
                    CMND = kh.CMND,
                    GIOITINH = kh.GioiTinh,
                    DIACHI = kh.DiaChi,
                    EMAIL = kh.Email,
                    
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
            var sua = ConectionData.dt.KHACHHANGs.Single(khachHang => khachHang.SDT == kh.Sdt);
            sua.TENKH = kh.TenKH;
            sua.CMND = kh.CMND;
            sua.GIOITINH = kh.GioiTinh;
            sua.DIACHI = kh.DiaChi;
            sua.EMAIL = kh.Email;

            ConectionData.dt.KHACHHANGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string sdt)
        {
            var xoa = from kh in ConectionData.dt.KHACHHANGs
                      where kh.SDT == sdt
                      select kh;
            foreach (var item in xoa)
            {
                ConectionData.dt.KHACHHANGs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }
        public DTO_KhachHang LayKhachHang(string sdt)
        {
            var lay = ConectionData.dt.KHACHHANGs
                .Where(kh => kh.SDT == sdt)
                .Select(kh => new DTO_KhachHang
                {
                    Sdt = kh.SDT,
                    TenKH = kh.TENKH,
                    CMND = kh.CMND,
                    DiaChi = kh.DIACHI,
                    Email = kh.EMAIL,
                    
                }).FirstOrDefault();
            
            return lay;
            
        }
        public DTO_KhachHang Lay1KhachHang(string maKS,string maPhong)
        {
            var khachHang = (from kh in ConectionData.dt.KHACHHANGs
                            join dp in ConectionData.dt.DATPHONGs on kh.SDT equals dp.SDT
                            join p in ConectionData.dt.PHONGs on dp.MAPHONG equals p.MAPHONG
                            where dp.MAKS == maKS && p.MAPHONG == maPhong
                            select new
                            {
                                TENKH = kh.TENKH,
                                CCCD = kh.CMND,
                                SDT = kh.SDT,
                                EMAIL = kh.EMAIL,
                                DIACHI = kh.DIACHI
                            }).ToList();
            DTO_KhachHang dtoKhachHang = null;
            foreach (var k in khachHang)
            {
                string tenKH = k.TENKH;
                string cccD = k.CCCD;
                string sdt = k.SDT;
                string email = k.EMAIL;
                string diaChi = k.DIACHI;
                dtoKhachHang = new DTO_KhachHang(sdt, tenKH, cccD, true, diaChi,email);
            }
            return dtoKhachHang;
        }
    }
}
