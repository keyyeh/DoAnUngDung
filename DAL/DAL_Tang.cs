using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Tang
    {
        public List<DTO_Tang> Xem()
        {
            var xem = from t in ConectionData.dt.TANGs
                      select t;
            List<DTO_Tang> tang = new List<DTO_Tang>();
            foreach (var item in xem)
            {
                DTO_Tang dtoTang = new DTO_Tang();
                dtoTang.MaTang = item.MATANG;
                dtoTang.Lau = item.LAU;
                tang.Add(dtoTang);
            }
            return tang;
        }

        public List<DTO_Phong> CheckTang(string maTang)
        {
            var xem = from t in ConectionData.dt.PHONGs
                      where t.MATANG == maTang
                      select t;
            List<DTO_Phong> phong = new List<DTO_Phong>();

            foreach (var item in xem)
            {
                DTO_Phong p = new DTO_Phong();
                p.MaKS = item.MAKS;
                p.MaPhong = item.MAPHONG;
                p.MaTang = item.MATANG;
                p.TenPhong = item.TENPHONG;
                p.LoaiPhong = item.LOAIPHONG;
                p.SucChua = item.SUCCHUA;
                phong.Add(p);
            }
            return phong;
        }
    }
}
