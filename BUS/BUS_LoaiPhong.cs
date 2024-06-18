using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiPhong
    {
        DAL_LoaiPhong lPhong = new DAL_LoaiPhong();
        public IQueryable Xem()
        {
            return lPhong.Xem();
        }
        public double LayGiaPhong(int maLP)
        {
            return lPhong.LayGiaPhong(maLP);
        }
        public string LayTenLPhong(int maLP)
        {
            return lPhong.LayTenLPhong(maLP);
        }
    }
}
