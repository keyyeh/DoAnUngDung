using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongTinDatPhong
    {
        DAL_ThongTinDatPhong datPhong = new DAL_ThongTinDatPhong();

        public IQueryable Xem()
        {
            return datPhong.Xem();
        }

        public int Them(DTO_ThongTinDatPhong dp)
        {
            return datPhong.Them(dp);
        }
    }
}
