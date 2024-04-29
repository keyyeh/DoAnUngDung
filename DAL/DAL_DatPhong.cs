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
                      join kh in ConectionData.dt.KHACHHANGs on dp.MAKH equals kh.MAKH
                      join p in ConectionData.dt.PHONGs on dp.MAPHONG equals p.MAPHONG
                      where dp.MAKS == maKS
                      select new
                      {
                          MAKH = kh.MAKH,
                          TENKH = kh.TENKH,
                          PHONG = p.TENPHONG,
                          CCCD = kh.CMND,
                          SDT = kh.SDT,
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
                    MAKH = dp.MaKH,
                    MAKS = dp.MaKS,
                    MAPHONG = dp.MaPhong,
                    NGAYDATPHONG = dp.NgayDatPhong
                };
                ConectionData.dt.DATPHONGs.InsertOnSubmit(datPhong);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }
        public void Sua(DTO_DatPhong dp)
        {
            var sua = ConectionData.dt.DATPHONGs.Single(datPhong => datPhong.MAKS == dp.MaKS);
            sua.NGAYTRAPHONG = dp.NgayTraPhong;

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