using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiPhong
    {
        public IQueryable Xem()
        {
            var xem = ConectionData.dt.LOAIPHONGs
                .Select(lp => lp);

            return xem;
        }
        public double LayGiaPhong(int maLP)
        {
            var giaPhong = ConectionData.dt.LOAIPHONGs
                .Where(lp => lp.MALOAIP == maLP)
                .Select(lp => lp.GIA)
                .SingleOrDefault();

            return (double)giaPhong;
        }
        public string LayTenLPhong(int maLP)
        {
            var lay = ConectionData.dt.LOAIPHONGs
                .Where(lp => lp.MALOAIP == maLP)
                .Select(lp => lp)
                .ToList();

            if (lay.Any())
            {
                string tenLPhong = lay[0].TENLOAIP;
                return tenLPhong;
            }
            return "";
        }
    }
}
