using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang khachHang = new DAL_KhachHang();
        public IQueryable Xem(string sdt)
        {
            return khachHang.Xem(sdt);
        }
        public int Them(DTO_KhachHang kh)
        {
            return khachHang.Them(kh);
        }
        public DTO_KhachHang Lay1KhachHang(int maPhong)
        {
            return khachHang.Lay1KhachHang(maPhong);
        }
        public DTO_KhachHang LayKhachHang(string sdt)
        {
            return khachHang.LayKhachHang(sdt);
        }
    }
}
