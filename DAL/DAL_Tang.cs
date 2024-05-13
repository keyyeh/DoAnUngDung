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
        public IQueryable XemPhong()
        {
            var xem = ConectionData.dt.TANGs
                .Select(d => d);
            return xem;
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
                p.Gia = item.GIA;
                p.SucChua = item.SUCCHUA;
                phong.Add(p);
            }
            return phong;
        }

        public string LayTenTang(string maTang)
        {
            var tangList = ConectionData.dt.TANGs
                .Where(d => d.MATANG == maTang)
                .Select(d => d)
                .ToList();

            // Kiểm tra xem danh sách có phần tử không
            if (tangList.Any())
            {
                // Lấy giá trị LAU từ phần tử đầu tiên trong danh sách (giả sử chỉ có một phần tử)
                string tenTang = tangList[0].LAU;
                return tenTang;
            }
            else
            {
                // Trả về null nếu không có phần tử nào trong danh sách
                return null;
            }
        }


    }
}
