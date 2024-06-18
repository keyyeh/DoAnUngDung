using System;
using System.Collections.Generic;
using System.Data;
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
                    MAHD = dp.MaHD,
                    SDT = dp.SDT,
                    MAPHONG = dp.MaPhong,
                    MASP = dp.MaSP,
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

        public void Sua(int maPhong)
        {
            var sua = ConectionData.dt.DATPHONGs.Single(datPhong => datPhong.MAPHONG == maPhong);
            sua.NGAYTRAPHONG = DateTime.Now;

            ConectionData.dt.DATPHONGs.InsertOnSubmit(sua);
            ConectionData.dt.SubmitChanges();
        }
        public int Xoa(int maPhong)
        {
            var xoa = from dp in ConectionData.dt.DATPHONGs
                      where dp.MAPHONG == maPhong
                      select dp;
            foreach (var item in xoa)
            {
                ConectionData.dt.DATPHONGs.DeleteOnSubmit(item);
                ConectionData.dt.SubmitChanges();
            }
            return 1;
        }

        public DTO_ThongTinDatPhong InPhieu(int maPhong)
        {
            var phieu = (from dp in ConectionData.dt.DATPHONGs
                        join kh in ConectionData.dt.KHACHHANGs on dp.SDT equals kh.SDT
                        join p in ConectionData.dt.PHONGs on dp.MAPHONG equals p.MAPHONG
                        where dp.MAPHONG == maPhong
                        select new DTO_ThongTinDatPhong
                        {
                            TenKH = kh.TENKH,
                            Sdt = kh.SDT,
                            NgayDatPhong = dp.NGAYDATPHONG.Value,
                            NgayTraPhong = dp.NGAYTRAPHONG.Value,
                            TongTien = dp.TONGTIEN.Value,
                        }).FirstOrDefault();
            return phieu;
        }

        public double TongTien(int maPhong)
        {
            var phieu = (from dp in ConectionData.dt.DATPHONGs
                         where dp.MAPHONG == maPhong
                         select new
                         {
                             TongTien = dp.TONGTIEN.Value,
                         }).Sum(t => t.TongTien);
            return phieu;
        }
        public double LayGiaPhong(int maPhong)
        {
            // Perform the query to get the price of the room
            var gia = ConectionData.dt.PHONGs
                .Where(p => p.MAPHONG == maPhong)
                .Join(ConectionData.dt.LOAIPHONGs,
                      p => p.MALOAIP,
                      lp => lp.MALOAIP,
                      (p, lp) => new
                      {
                          Gia = lp.GIA
                      })
                .Select(result => result.Gia) // Select the price
                .SingleOrDefault(); // Get the single price value or default if not found

            return (double)gia; // Return the price as a double
        }

        public DataTable LayDuLieu(int maPhong)
        {

            var xem = (from sp in ConectionData.dt.SANPHAMs
                       join dp in ConectionData.dt.DATPHONGs on sp.MASP equals dp.MASP
                       where dp.MAPHONG == maPhong && sp.GIA != 0
                       select new
                       {
                           TENSP = sp.TENSP,
                           SOLUONG = dp.TONGTIEN / sp.GIA,
                           GIA = sp.GIA,
                           THANHTIEN = dp.TONGTIEN,
                       }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Giá", typeof(double));
            dt.Columns.Add("Thành tiền", typeof(double));

            foreach (var item in xem)
            {
                dt.Rows.Add(item.TENSP, item.SOLUONG, item.GIA, item.THANHTIEN);
            }
            return dt;
        }
        public DTO_DatPhong Lay1DatPhong(int maPhong)
        {
            var lay = ConectionData.dt.DATPHONGs
                .Where(dp => dp.MAPHONG == maPhong)
                .Select(dp => new DTO_DatPhong
                {
                    MaHD = dp.MAHD,
                    SDT = dp.SDT,
                    MaPhong = dp.MAPHONG,
                    MaSP = dp.MASP,
                    TongTien = (double)dp.TONGTIEN,
                    NgayDatPhong = (DateTime)dp.NGAYDATPHONG,
                    NgayTraPhong = (DateTime)dp.NGAYTRAPHONG
                }).FirstOrDefault();
            return lay;
        }
        public double TongTien(string maKS,int maPhong)
        {
            var tongTien = ConectionData.dt.PHONGs
                .Join(ConectionData.dt.LOAIPHONGs,
                p => p.MALOAIP,
                lp => lp.MALOAIP,
                (p, lp) => new
                {
                    p,
                    lp
                })
                .Where(phong => phong.p.MAKS == maKS && phong.p.MAPHONG == maPhong)
                .Join(ConectionData.dt.HINHTHUCDATPHONGs,
                pl => pl.p.MAHT,
                ht => ht.MAHT,
                (pl, ht) => new
                {
                    GIALOAIPHONG = pl.lp.GIA,
                    GIAHT = ht.GIA,
                })
                .Sum(x => x.GIAHT + x.GIALOAIPHONG);
            return (double)tongTien;
        }

        public double TongHoaDon(string sdt,int maPhong,string maKS)
        {
            var tong = ConectionData.dt.DATPHONGs
                .Join(ConectionData.dt.PHONGs,
                dp => dp.MAPHONG,
                p => p.MAPHONG,
                (dp, p) => new
                {
                    dp,
                    TONGTIEN = dp.TONGTIEN,
                    p
                })
                .Where(k => k.dp.SDT == sdt && k.dp.MAPHONG == maPhong && k.p.MAKS == maKS).ToList();
            double t = 0;
            foreach (var k in tong)
            {
                t += (double)k.TONGTIEN;
            }
            return t;
        }
        public DataTable InHoaDon(string sdt,int maPhong)
        {
            var inHD = (from dp in ConectionData.dt.DATPHONGs
                       join sp in ConectionData.dt.SANPHAMs on dp.MASP equals sp.MASP
                       join kh in ConectionData.dt.KHACHHANGs on dp.SDT equals kh.SDT
                       join hd in ConectionData.dt.HOADONs on dp.MAHD equals hd.MAHD
                       join nv in ConectionData.dt.NHANVIENs on hd.MANV equals nv.MANV
                       where dp.SDT == sdt && dp.MAPHONG == maPhong
                       select new
                       {
                           MaHD = dp.MAHD,
                           TenKH = kh.TENKH,
                           Sdt = dp.SDT,
                           TenSP = sp.TENSP,
                           SoLuong = dp.TONGTIEN / (sp.GIA + 1),
                           DonGia = sp.GIA,
                           ThanhTien = dp.TONGTIEN,
                           NgayDatPhong = dp.NGAYDATPHONG,
                           NgayTraPhong = dp.NGAYTRAPHONG,
                           TenNV = nv.TENNV
                       }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD", typeof(string));
            dt.Columns.Add("TenKH", typeof(string));
            dt.Columns.Add("Sdt", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double));
            dt.Columns.Add("NgayDatPhong", typeof(DateTime));
            dt.Columns.Add("NgayTraPhong", typeof(DateTime));
            // Compute the total amount (TongTien)
            double totalAmount = (double)inHD.Sum(x => x.ThanhTien);

            // Add the TongTien column
            dt.Columns.Add("TongTien", typeof(double));
            dt.Columns.Add("TenNV", typeof(string));

            foreach (var x in inHD)
            {
                dt.Rows.Add(x.MaHD,x.TenKH,x.Sdt,x.TenSP,x.SoLuong,x.DonGia,x.ThanhTien,x.NgayDatPhong,x.NgayTraPhong,totalAmount,x.TenNV);
            }
            return dt;
        }

        public int Sua(DTO_DatPhong datPhong)
        {
            var sua = ConectionData.dt.DATPHONGs.FirstOrDefault(dp => dp.MAPHONG == datPhong.MaPhong);

            if (sua != null)
            {
                sua.MAHD = datPhong.MaHD;
                sua.SDT = datPhong.SDT;
                sua.MASP = datPhong.MaSP;
                sua.NGAYDATPHONG = datPhong.NgayDatPhong;
                sua.NGAYTRAPHONG = datPhong.NgayTraPhong;
                sua.TONGTIEN = datPhong.TongTien;
                ConectionData.dt.SubmitChanges();
                return 1;
            }
            else
            {
                // Handle the case where no matching element is found
                return 0; // or another appropriate value or action
            }

        }
    }
}