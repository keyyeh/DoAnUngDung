using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiSP
    {
        DAL_LoaiSP sanPham = new DAL_LoaiSP();
        public IQueryable Xem()
        {
            return sanPham.Xem();
        }
        public int Them(DTO_LoaiSP sp)
        {
            return sanPham.Them(sp);
        }
        public int Sua(DTO_LoaiSP sp)
        {
            return sanPham.Sua(sp);
        }
        public int Xoa(int maLoai)
        {
            return sanPham.Xoa(maLoai);
        }
    }
}
