using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu
    {
        public IQueryable Xem()
        {
            var xem = ConectionData.dt.CHUCVUs
                .Select(cv => cv);
            return xem;
        }
        public string LayTenCV(string maCV)
        {
            var tangList = ConectionData.dt.CHUCVUs
                .Where(d => d.MACV == maCV)
                .Select(d => d)
                .ToList();

            // Kiểm tra xem danh sách có phần tử không
            if (tangList.Any())
            {
                // Lấy giá trị LAU từ phần tử đầu tiên trong danh sách (giả sử chỉ có một phần tử)
                string tenTang = tangList[0].TENCV;
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
