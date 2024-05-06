using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DatPhong
    {
        public IQueryable Xem(string sdt)
        {
            var xem = from dp in ConectionData.dt.DATPHONGs  
                      join kh in ConectionData.dt.KHACHHANGs on dp.SDT equals kh.SDT
                      join p in ConectionData.dt.PHONGs on dp.MAPHONG equals p.MAPHONG
                      where dp.SDT == sdt
                      select new
                      {
                          PHONG = p.TENPHONG,
                          TENKHACHHANG = kh.TENKH,
                          SDT = kh.SDT,
                          CCCD = kh.CMND,
                          EMAIL = kh.EMAIL,
                          GIOITINH = kh.GIOITINH,
                      };
            return xem;
        }
        public int Them(DTO_DatPhong dp)
        {
            try
            {
                if (dp == null)
                    throw new ArgumentNullException(nameof(dp), "DTO_DatPhong không được null.");

                DATPHONG datPhong = new DATPHONG
                {
                    MAKS = dp.MaKS,
                    SDT = dp.SDT,
                    MAPHONG = dp.MaPhong,
                    NGAYDATPHONG = dp.NgayDatPhong,
                    NGAYTRAPHONG = dp.NgayTraPhong,
                    TONGTIEN = dp.TongTien
                };

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.DATPHONGs.InsertOnSubmit(datPhong);
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

        public void Sua(string maPhong)
        {
            var sua = ConectionData.dt.DATPHONGs.Single(datPhong => datPhong.MAPHONG == maPhong);
            sua.NGAYTRAPHONG = DateTime.Now;

            ConectionData.dt.DATPHONGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public void Xoa(string maKS)
        {
            var xoa = from dp in ConectionData.dt.DATPHONGs
                      where dp.MAKS == maKS
                      select dp;
            foreach (var item in xoa)
            {
                ConectionData.dt.DATPHONGs.InsertOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
        }
    }
}