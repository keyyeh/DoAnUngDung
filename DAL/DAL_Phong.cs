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
        public int Them(DTO_Phong p)
        {
            try
            {
                PHONG phong = new PHONG
                {
                    MAPHONG = p.MaPhong,
                    MAKS = p.MaKS,
                    TENPHONG = p.TenPhong,
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
            return 1;
        }
        public int Sua(DTO_Phong p)
        {
            var sua = ConectionData.dt.PHONGs.Single(phong => phong.MAPHONG == p.MaPhong);

            sua.MAKS = p.MaKS;
            sua.TENPHONG = p.TenPhong;
            sua.LOAIPHONG = p.LoaiPhong;
            sua.GIA = p.Gia;
            sua.SUCCHUA = p.SucChua;

            ConectionData.dt.PHONGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
            return 1;
        }
        public int Xoa(string maPhong)
        {
            var xoa = from p in ConectionData.dt.PHONGs
                      where p.MAPHONG == maPhong
                      select p;
            foreach (var item in xoa)
            {
                ConectionData.dt.PHONGs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }
        public List<DTO_Phong> LayDuLieu()
        {
            var phong = from p in ConectionData.dt.PHONGs
                        select p;
            List<DTO_Phong> listPhong = new List<DTO_Phong>();
            foreach(var item in phong)
            {
                DTO_Phong values = new DTO_Phong();
                values.MaPhong = item.MAPHONG;
                values.MaKS = item.MAKS;
                values.TenPhong = item.TENPHONG;
                values.LoaiPhong = item.LOAIPHONG;
                values.Gia = item.GIA;
                values.SucChua = item.SUCCHUA;
                listPhong.Add(values);
            }
            return listPhong;
        }

        public DTO_Phong Lay1Phong(string maKS, string maPhong)
        {
            var phong = ConectionData.dt.PHONGs
                .Where(p => p.MAKS == maKS)
                .Select(p => new DTO_Phong
                {
                    MaPhong = p.MAPHONG,
                    MaKS = p.MAKS,
                    TenPhong = p.TENPHONG,
                    LoaiPhong = p.LOAIPHONG,
                    Gia = p.GIA,
                    SucChua = p.SUCCHUA,
                });
            List<DTO_Phong> phongs = phong.ToList();
            foreach(DTO_Phong item in phongs)
            {
                if (item.MaPhong == maPhong)
                {
                    return item;
                }
            }
                //{
                //    MaPhong = p.MAPHONG,
                //    MaKS = p.MAKS,
                //    TenPhong = p.TENPHONG,
                //    LoaiPhong = p.LOAIPHONG,
                //    Gia = p.GIA,
                //    SucChua = p.SUCCHUA,
                //}).FirstOrDefault();
            return null;
        }
    }
}