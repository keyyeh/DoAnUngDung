using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham sanPham = new DAL_SanPham();
        public DataTable Xem(int maLoai)
        {
            return sanPham.Xem(maLoai);
        }
        public int Them(DTO_SanPham sp)
        {
            return sanPham.Them(sp);
        }
        public int Sua(DTO_SanPham sp)
        {
            return sanPham.Sua(sp);
        }
        public int Xoa(int maSP)
        {
            return sanPham.Xoa(maSP);
        }
        public DTO_SanPham LayDuLieu(int  maSP)
        {
            return sanPham.LayDuLieu(maSP);
        }
    }
}
