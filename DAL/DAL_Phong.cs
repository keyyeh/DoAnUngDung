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
        public int TimViTriPhong(int maMP)
        {
            var phong = from p in ConectionData.dt.PHONGs
                        select p;

            int i = 0;
            foreach (var phongItem in phong)
            {
                if (phongItem.MAPHONG == maMP)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public bool CheckPhong(int maPhong)
        {
            var check = (from kh in ConectionData.dt.KHACHHANGs
                         join dp in ConectionData.dt.DATPHONGs on kh.SDT equals dp.SDT
                         where dp.MAPHONG == maPhong
                         select kh).Any();
            return check;
        }

        public int Them(DTO_Phong p)
        {
            try
            {
                PHONG phong = new PHONG
                {
                    MAPHONG = p.MaPhong,
                    MAKS = p.MaKS,
                    MATANG = p.MaTang,
                    TENPHONG = p.TenPhong,
                    MALOAIP = p.MaLoaiP,
                    MAHT = p.MaHT,
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
            sua.MATANG = p.MaTang;
            sua.TENPHONG = p.TenPhong;
            sua.MALOAIP = p.MaLoaiP;
            sua.MAHT = p.MaHT;
            sua.SUCCHUA = p.SucChua;
            ConectionData.dt.SubmitChanges();
            return 1;
        }
        public int Xoa(int maPhong)
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
                values.MaTang = item.MATANG;
                values.TenPhong = item.TENPHONG;
                values.MaLoaiP = item.MALOAIP;
                values.MaHT = item.MAHT;
                values.SucChua = item.SUCCHUA;
                listPhong.Add(values);
            }
            return listPhong;
        }

        public DTO_Phong Lay1Phong(int maTang,int maPhong)
        {
            var phong = ConectionData.dt.PHONGs
                .Where(p => p.MATANG == maTang)
                .Select(p => new DTO_Phong
                {
                    MaPhong = p.MAPHONG,
                    MaKS = p.MAKS,
                    MaTang = p.MATANG,
                    TenPhong = p.TENPHONG,
                    MaLoaiP = p.MALOAIP,
                    MaHT = p.MAHT,
                    SucChua = p.SUCCHUA
                });
            List<DTO_Phong> phongs = phong.ToList();
            foreach(DTO_Phong item in phongs)
            {
                if (item.MaPhong == maPhong)
                {
                    return item;
                }
            }
            return null;
        }
    }
}