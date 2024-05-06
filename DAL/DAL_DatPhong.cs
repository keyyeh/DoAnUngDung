using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DatPhong
    {
        public IQueryable Xem(string maKS)
        {
            var xem = from dp in ConectionData.dt.DATPHONGs  
                      join kh in ConectionData.dt.KHACHHANGs on dp.SDT equals kh.SDT
                      join p in ConectionData.dt.PHONGs on dp.MAPHONG equals p.MAPHONG
                      where dp.MAKS == maKS
                      select new
                      {
                          SDT = kh.SDT,
                          TENKH = kh.TENKH,
                          PHONG = p.TENPHONG,
                          CCCD = kh.CMND,
                          EMAIL = kh.EMAIL,
                          GIOITINH = kh.GIOITINH,
                      };
            return xem;
        }
        public int Them(DTO_DatPhong dp)
        {
            try
            {
                DATPHONG datPhong = new DATPHONG
                {
                    
                    MAKS = dp.MaKS,
                    SDT = dp.SDT,
                    MAPHONG = dp.MaPhong,
                    NGAYDATPHONG = dp.NgayDatPhong,
                    NGAYTRAPHONG = dp.NgayTraPhong
                };
                ConectionData.dt.DATPHONGs.InsertOnSubmit(datPhong);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }
        public void Sua(string maPhong)
        {
            var sua = ConectionData.dt.DATPHONGs.Single(datPhong => datPhong.MAPHONG == maPhong);
            sua.NGAYTRAPHONG = DateTime.Now;

            ConectionData.dt.DATPHONGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string maKS)
        {
            var xoa = from dp in ConectionData.dt.DATPHONGs
                      where dp.MAKS == maKS
                      select dp;
            foreach (var item in xoa)
            {
                ConectionData.dt.DATPHONGs.InsertOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }
    }
}