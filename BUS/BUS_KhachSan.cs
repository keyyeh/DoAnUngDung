using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachSan
    {
        DAL_KhachSan khachSan = new DAL_KhachSan();
        public IQueryable Xem()
        {
            return khachSan.Xem();
        }

        public int Them(DTO_KhachSan ks)
        {
            return khachSan.Them(ks);
        }

        public int Sua(DTO_KhachSan ks)
        {
            return khachSan.Sua(ks);
        }

        public int Xoa(string maKS)
        {
            return khachSan.Xoa(maKS);
        }
        public DTO_KhachSan LayDuLieu(string maKS)
        {
            return khachSan.LayDuLieu(maKS);
        }
    }
}
