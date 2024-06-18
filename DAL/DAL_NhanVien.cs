using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        public IQueryable Xem()
        {
            var nhanVien = from nv in ConectionData.dt.NHANVIENs
                           join cv in ConectionData.dt.CHUCVUs on nv.MACHUCVU equals cv.MACV
                           select new
                           {
                               MANV = nv.MANV,
                               TEN = nv.HONV + " " + nv.TENNV,
                               CHUCVU = cv.TENCV,
                               NGAYSINH = nv.NGAYSINH,
                               SDT = nv.SDT,
                               DIACHI = nv.DIACHI,
                           };
            return nhanVien;
        }
        public int Them(DTO_NhanVien nv)
        {
            try
            {
                if (nv == null)
                    throw new ArgumentNullException(nameof(nv), "DTO_DatPhong không được null.");

                NHANVIEN nhanVien = new NHANVIEN
                {
                    MANV = nv.MaNV,
                    MAKS = nv.MaKS,
                    MACHUCVU = nv.MaChucVu,
                    HINHANH = nv.Image,
                    HONV = nv.HoNV,
                    TENNV = nv.TenNV,
                    NGAYSINH = nv.NgaySinh,
                    SDT = nv.Sdt,
                    DIACHI = nv.DiaChi,
                };


                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.NHANVIENs.InsertOnSubmit(nhanVien);
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
        public int Sua(DTO_NhanVien nv)
        {
            // Tìm nhân viên cần sửa
            var sua = ConectionData.dt.NHANVIENs.SingleOrDefault(nhanVien => nhanVien.MANV == nv.MaNV);

            // Kiểm tra xem nhân viên có tồn tại không
            if (sua == null)
            {
                // Trả về 0 để chỉ ra rằng không tìm thấy nhân viên
                return 0;
            }

            // Cập nhật thông tin của nhân viên
            sua.MAKS = nv.MaKS;
            sua.MACHUCVU = nv.MaChucVu;
            sua.HINHANH = nv.Image;
            sua.HONV = nv.HoNV;
            sua.TENNV = nv.TenNV;
            sua.NGAYSINH = nv.NgaySinh;
            sua.SDT = nv.Sdt;
            sua.DIACHI = nv.DiaChi;

            // Thực hiện việc cập nhật trong cơ sở dữ liệu

            ConectionData.dt.SubmitChanges();

            // Trả về 1 để chỉ ra rằng cập nhật thành công
            return 1;
        }

        public int Xoa(string maNV)
        {
            // Tìm tất cả các nhân viên có mã maNV cần xóa
            var xoa = from NV in ConectionData.dt.NHANVIENs
                      where NV.MANV == maNV
                      select NV;

            // Kiểm tra xem có bản ghi cần xóa không
            if (xoa.Any())
            {
                // Duyệt qua tất cả các nhân viên tìm được và xóa chúng
                foreach (var item in xoa)
                {
                    ConectionData.dt.NHANVIENs.DeleteOnSubmit(item);
                }

                // Thực hiện lưu thay đổi vào cơ sở dữ liệu
                ConectionData.dt.SubmitChanges();

                // Trả về 1 để chỉ ra rằng việc xóa đã thành công
                return 1;
            }
            else
            {
                // Trả về 0 để chỉ ra rằng không có bản ghi nào được xóa
                return 0;
            }
        }


        public DTO_NhanVien LayNhanVien(string maNV)
        {
            // Truy vấn cơ sở dữ liệu để lấy thông tin nhân viên, không chuyển đổi HINHANH ở đây
            var nhanVien = ConectionData.dt.NHANVIENs
                .Where(nv => nv.MANV == maNV)
                .Select(nv => new
                {
                    nv.MANV,
                    nv.MAKS,
                    nv.MACHUCVU,
                    nv.HONV,
                    nv.TENNV,
                    nv.SDT,
                    nv.DIACHI,
                    nv.NGAYSINH,
                    nv.HINHANH
                })
                .FirstOrDefault();

            if (nhanVien == null)
            {
                return null; // hoặc xử lý khi không tìm thấy nhân viên
            }

            // Chuyển đổi dữ liệu sang DTO_NhanVien
            var dtoNhanVien = new DTO_NhanVien
            {
                MaNV = nhanVien.MANV,
                MaKS = nhanVien.MAKS,
                MaChucVu = nhanVien.MACHUCVU,
                HoNV = nhanVien.HONV,
                TenNV = nhanVien.TENNV,
                Sdt = nhanVien.SDT ?? "",
                DiaChi = nhanVien.DIACHI ?? "",
                NgaySinh = nhanVien.NGAYSINH ?? DateTime.Now,
                Image = nhanVien.HINHANH?.ToArray() ?? new byte[0] // Chuyển đổi HINHANH sau khi đã tải dữ liệu
            };

            return dtoNhanVien;
        }

    }
}
