using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatMon
    {
        public int Them(DTO_DatMon dm)
        {
            try
            {
                
                DATMON datMon = new DATMON
                {
                    MASP = dm.MaSP,
                    MAPHONG = dm.MaPhong,
                    TONGTIEN = dm.TongTien,
                };

                if (ConectionData.dt == null)
                    throw new Exception("Không thể kết nối đến cơ sở dữ liệu.");

                ConectionData.dt.DATMONs.InsertOnSubmit(datMon);
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
        public DataTable LayDuLieu(string maPhong)
        {
            var xem = (from dp in ConectionData.dt.DATMONs
                      join sp in ConectionData.dt.SANPHAMs on dp.MASP equals sp.MASP
                      where dp.MAPHONG == maPhong
                      select new
                      {
                          TENSP = sp.TENSP,
                          SOLUONG = dp.TONGTIEN / sp.GIA,
                          GIA = sp.GIA,
                          THANHTIEN = dp.TONGTIEN,
                      }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm",typeof(string));
            dt.Columns.Add("Số lượng",typeof(int));
            dt.Columns.Add("Giá",typeof(double));
            dt.Columns.Add("Thành tiền", typeof(double));

            foreach (var item in xem)
            {
                dt.Rows.Add(item.TENSP, item.SOLUONG, item.GIA, item.THANHTIEN);
            }
            return dt;
        }
        public int Xoa(string maPhong)
        {
            var xoa = from d in ConectionData.dt.DATMONs
                      where d.MAPHONG == maPhong
                      select d;

            foreach (var item in xoa.ToList())
            {
                ConectionData.dt.DATMONs.DeleteOnSubmit(item);
            }

            // Gọi SubmitChanges() sau khi hoàn thành tất cả các thao tác xóa
            ConectionData.dt.SubmitChanges();

            return 1;
        }

    }
}
