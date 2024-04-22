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
        public IQueryable Xem()
        {
            var Xem = from DP in ConectionData.dt.PHONGs
                      select DP;
            return Xem;
        }
        public void Them(DTO_DatPhong dp)
        {
            try
            {
                DATPHONG datPhong = new DATPHONG
                {
                    MAKS = dp.MaKS,
                    MAKH = dp.MaKH,
                    NGAYDATPHONG = dp.NgayDatPhong,
                    NGAYTRAPHONG = dp.NgayTraPhong,
                };
                ConectionData.dt.DATPHONGs.InsertOnSubmit(datPhong);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
        }
        public void Sua(DTO_DatPhong dp)
        {
            var sua = ConectionData.dt.DATPHONGs.Single(datPhong => datPhong.MAKS == dp.MaKS);
            sua.NGAYDATPHONG = dp.NgayDatPhong;
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