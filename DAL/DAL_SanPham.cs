using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        public DataTable Xem(int maLoai)
        {
            var xem = ConectionData.dt.SANPHAMs
                .Where(sp => sp.MALOAI == maLoai)
                .Select(sp => sp).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("maSP",typeof(int));
            dt.Columns.Add("tenSP",typeof (string));
            dt.Columns.Add("maLoai", typeof(int));
            dt.Columns.Add("gia", typeof(double));
            dt.Columns.Add("donVi", typeof(string));

            foreach (var item in xem)
            {
                dt.Rows.Add(item.MASP, item.TENSP, item.MALOAI, item.GIA, item.DONVI);
            }
            return dt;
        }
        public int Them(DTO_SanPham sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "DTO_DatPhong không được null.");

                SANPHAM sanPham = new SANPHAM
                {
                    MASP = sp.MaSP,
                    TENSP = sp.TenSP,
                    MALOAI = sp.MaLoai,
                    GIA = sp.Gia,
                    DONVI = sp.DonVi,
                };

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.SANPHAMs.InsertOnSubmit(sanPham);
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
        public int Sua(DTO_SanPham sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "DTO_DatPhong không được null.");

                var sua = ConectionData.dt.SANPHAMs.Single(sanPham => sanPham.MASP == sp.MaSP);
                sua.TENSP = sp.TenSP;
                sua.GIA = sp.Gia;
                sua.DONVI = sp.DonVi;

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.SANPHAMs.InsertOnSubmit(sua);
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
        public int Xoa(int maSP)
        {
            var xoa = ConectionData.dt.SANPHAMs
                .Where(sanPham => sanPham.MASP == maSP)
                .Select(sanPham => sanPham);
            foreach (var sanPham in xoa)
            {
                ConectionData.dt.SANPHAMs.DeleteOnSubmit(sanPham);
                ConectionData.dt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public DTO_SanPham LayDuLieu(int maSP)
        {
            var lay = ConectionData.dt.SANPHAMs
                .Where(l => l.MASP == maSP)
                .Select(l => new DTO_SanPham
                {
                    MaSP = maSP,
                    TenSP = l.TENSP,
                    MaLoai = l.MASP,
                    Gia = l.GIA,
                    DonVi = l.DONVI,
                }).FirstOrDefault();
            return lay;
        }
    }
}
