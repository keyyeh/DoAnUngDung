using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiSP
    {
        public IQueryable Xem()
        {
            var xem = from sp in ConectionData.dt.LOAISPs
                      select sp;
            return xem;
        }

        public int Them(DTO_LoaiSP sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "DTO_DatPhong không được null.");

                LOAISP loaiSP = new LOAISP
                {
                    MALOAI = sp.MaLoai,
                    TENLOAI = sp.TenLoai,
                };

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.LOAISPs.InsertOnSubmit(loaiSP);
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
        public int Sua(DTO_LoaiSP sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "DTO_DatPhong không được null.");

                var sua = ConectionData.dt.LOAISPs.Single(sanPham => sanPham.MALOAI == sp.MaLoai);
                sua.TENLOAI = sp.TenLoai;

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.LOAISPs.InsertOnSubmit(sua);
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
        public int Xoa(int maLoai)
        {
            var xoa = ConectionData.dt.LOAISPs
                .Where(sanPham => sanPham.MALOAI == maLoai)
                .Select(sanPham => sanPham);
            foreach (var sanPham in xoa)
            {
                ConectionData.dt.LOAISPs.DeleteOnSubmit(sanPham);
                ConectionData.dt.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}
