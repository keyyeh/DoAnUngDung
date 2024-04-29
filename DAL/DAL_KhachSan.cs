using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachSan
    {
        public IQueryable Xem()
        {
            IQueryable khachSan = from ks in ConectionData.dt.KHACHHANGs
                                  select ks;

            return khachSan;
        }

        public int Them(DTO_KhachSan ks)
        {
            try
            {
                KHACHSAN khachSan = new KHACHSAN
                {
                    MAKS = ks.MaKS,
                    ADMINID = ks.ADmin,
                    TENKS = ks.TenKS,
                    DIADIEM = ks.DiaDiem,
                    DANHGIA = ks.DanhGia,
                    SDT = ks.SDT,
                };
                ConectionData.dt.KHACHSANs.InsertOnSubmit(khachSan);
            }finally { ConectionData.dt.SubmitChanges(); }
            return 1;
        }

        public int Sua(DTO_KhachSan ks)
        {
            var sua = ConectionData.dt.KHACHSANs.Single(khachSan => khachSan.MAKS == ks.MaKS);
            sua.ADMINID = ks.ADmin;
            sua.TENKS = ks.TenKS;
            sua.DIADIEM = ks.DiaDiem;
            sua.DANHGIA = ks.DanhGia;
            sua.SDT = ks.SDT;
            ConectionData.dt.KHACHSANs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
            return 1;
        }

        public int Xoa(string maKS)
        {
            var xoa = from ks in ConectionData.dt.KHACHSANs
                      where ks.MAKS == maKS
                      select ks;

            foreach (var k in xoa)
            {
                ConectionData.dt.KHACHSANs.DeleteOnSubmit(k);
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }

        public DTO_KhachSan LayDuLieu(string maKS)
        {
            var khachSan = ConectionData.dt.KHACHSANs
                                .Where(ks => ks.MAKS == maKS)
                                .Select(ks => new DTO_KhachSan
                                {
                                    MaKS = ks.MAKS,
                                    ADmin = ks.ADMINID,
                                    TenKS = ks.TENKS,
                                    DiaDiem = ks.DIADIEM,
                                    DanhGia = ks.DANHGIA,
                                    SDT = ks.SDT
                                })
                                .FirstOrDefault();

            return khachSan;
        }

    }
}
