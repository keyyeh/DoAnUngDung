using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HinhThuc
    {
        DAL_HinhThuc hinhThuc = new DAL_HinhThuc();
        public IQueryable Xem()
        {
            return hinhThuc.Xem();
        }
        public double LayGiaHT(int maHT)
        {
            return hinhThuc.LayGiaHT(maHT);
        }
    }
}
