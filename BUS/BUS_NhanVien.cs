using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nhanVien = new DAL_NhanVien();
        public IQueryable Xem()
        {
            return nhanVien.Xem();
        }
        public int Them(DTO_NhanVien nv)
        {
            return nhanVien.Them(nv);
        }
        public DTO_NhanVien LayNhanVien(string maNV)
        {
            return nhanVien.LayNhanVien(maNV);
        }
        public int Sua(DTO_NhanVien nv)
        {
            return nhanVien.Sua(nv);
        }
        public int Xoa(string maNV)
        {
            return nhanVien.Xoa(maNV);
        }
    }
}
