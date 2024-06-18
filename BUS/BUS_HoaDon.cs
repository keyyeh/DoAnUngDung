using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon hoaDon = new DAL_HoaDon();
        public bool Them(string maHD,string maNV)
        {
            return hoaDon.Them(maHD, maNV);
        }
        public bool Sua(string maHD, double tongTien, string tenKh, string tenPhong)
        {
            return hoaDon.Sua(maHD, tongTien,tenKh,tenPhong);
        }
        public DataTable BaoCaoTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            return hoaDon.BaoCaoTheoKhoangNgay(tuNgay, denNgay);
        }
        public DataTable BaoCaoTheoKhoangNgay(int thang)
        {
            return hoaDon.BaoCaoTheoKhoangNgay(thang);
        }
    }
}
