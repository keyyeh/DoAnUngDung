using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        public bool Them(string maHD,string maNV)
        {
			try
			{
				HOADON hd = new HOADON
				{
					MAHD = maHD,
					MANV = maNV,
					NGAYLAPHD = DateTime.Now,
					TONGTIEN = 0,
				};
				ConectionData.dt.HOADONs.InsertOnSubmit(hd);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				ConectionData.dt.SubmitChanges();
			}
        }
		public bool Sua(string maHD,double tongTien, string tenKh, string tenPhong)
		{
			var sua = ConectionData.dt.HOADONs.Single(hd => hd.MAHD == maHD);
			sua.TONGTIEN = tongTien;
			sua.TENKH = tenKh;
			sua.TENPHONG = tenPhong;
			ConectionData.dt.SubmitChanges();
			return true;
		}
		public DataTable BaoCaoTheoKhoangNgay(DateTime tuNgay,DateTime denNgay)
		{
			var xem = from hd in ConectionData.dt.HOADONs
					  where hd.NGAYLAPHD >= tuNgay && hd.NGAYLAPHD <= denNgay && hd.TONGTIEN != 0
					  join nv in ConectionData.dt.NHANVIENs on hd.MANV equals nv.MANV
					  select new
					  {
						  MaHD = hd.MAHD,
						  NguoiLapHoaDon = nv.HONV + nv.TENNV,
						  TenKhachHang = hd.TENKH,
						  Phong = hd.TENPHONG,
						  Ngay = hd.NGAYLAPHD,
						  TongTien = hd.TONGTIEN
					  };
			DataTable dt = new DataTable();
			dt.Columns.Add("MaHD", typeof(string));
			dt.Columns.Add("NguoiLapHoaDon", typeof(string));
			dt.Columns.Add("TenKhachHang", typeof(string));
			dt.Columns.Add("Phong", typeof(string));
			dt.Columns.Add("Ngay", typeof(DateTime));

			//double tong = (double)xem.Sum(t => t.TongTien);
            dt.Columns.Add("TongTien", typeof(double));
			foreach (var row in xem)
			{
				dt.Rows.Add(row.MaHD,row.NguoiLapHoaDon,row.TenKhachHang,row.Phong,row.Ngay,row.TongTien);
			}
			return dt;
        }
        public DataTable BaoCaoTheoKhoangNgay(int thang)
        {
            var xem = from hd in ConectionData.dt.HOADONs
					  let ngayLap = (DateTime)hd.NGAYLAPHD.Value
                      where ngayLap.Month == thang
                      join nv in ConectionData.dt.NHANVIENs on hd.MANV equals nv.MANV
                      select new
                      {
                          MaHD = hd.MAHD,
                          NguoiLapHoaDon = nv.HONV + nv.TENNV,
                          TenKhachHang = hd.TENKH,
                          Phong = hd.TENPHONG,
                          Ngay = hd.NGAYLAPHD,
                          TongTien = hd.TONGTIEN
                      };
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD", typeof(string));
            dt.Columns.Add("NguoiLapHoaDon", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("Phong", typeof(string));
            dt.Columns.Add("Ngay", typeof(DateTime));

            //double tong = (double)xem.Sum(t => t.TongTien);
            dt.Columns.Add("TongTien", typeof(double));
            foreach (var row in xem)
            {
                dt.Rows.Add(row.MaHD, row.NguoiLapHoaDon, row.TenKhachHang, row.Phong, row.Ngay, row.TongTien);
            }
            return dt;
        }
    }
}
