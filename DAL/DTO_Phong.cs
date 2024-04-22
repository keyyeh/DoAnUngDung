using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Phong
    {
        public IQueryable Xem()
        {
            var phong = from P in ConectionData.dt.PHONGs
                        select P;
            return phong;
        }
        public void Them(DTO_Phong p)
        {
            try
            {
                PHONG phong = new PHONG
                {
                    MAPHONG = p.MaPhong,
                    MAKS = p.MaKS,
                    LOAIPHONG = p.LoaiPhong,
                    GIA = p.Gia,
                    SUCCHUA = p.SucChua,
                };
                ConectionData.dt.PHONGs.InsertOnSubmit(phong);
            }
            finally
            {
                ConectionData.dt.SubmitChanges();
            }
        }
        public void Sua(DTO_Phong p)
        {
            var sua = ConectionData.dt.PHONGs.Single(phong => phong.MAPHONG == p.MaPhong);

            sua.MAKS = p.MaKS;
            sua.LOAIPHONG = p.LoaiPhong;
            sua.GIA = p.Gia;
            sua.SUCCHUA = p.SucChua;

            ConectionData.dt.PHONGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string maPhong)
        {
            var xoa = from p in ConectionData.dt.PHONGs
                      where p.MAPHONG == maPhong
                      select p;
            foreach (var item in xoa)
            {
                ConectionData.dt.PHONGs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }
    }
}