using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongTinDatPhong
    {
        public IQueryable Xem()
        {
            var xem = ConectionData.dt.DATPHONGs
                .Select(dp => dp);
            return xem;
        }

        public int Them(DTO_ThongTinDatPhong datPhong)
        {
            try
            { 
                HOADON hd = new HOADON
                {
                    MAHD = datPhong.MaKS,
                    TENKS = datPhong.TenKS,
                    TENKH = datPhong.TenKH,
                    SDT = datPhong.Sdt,
                    NGAYDATPHONG = datPhong.NgayDatPhong,
                    NGATTRAPHONG = datPhong.NgayTraPhong,
                    TONGTIEN = datPhong.TongTien
                };

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.HOADONs.InsertOnSubmit(hd);
                ConectionData.dt.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                // Ghi log hoặc xử lý lỗi ở đây
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return 0; // Hoặc bất kỳ mã lỗi nào bạn muốn trả về
            }
        }
    }
}
