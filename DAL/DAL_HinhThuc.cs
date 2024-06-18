using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HinhThuc
    {
        public IQueryable Xem()
        {
            var xem = ConectionData.dt.HINHTHUCDATPHONGs
                .Select(ht => ht);
            return xem;
        }
        public double LayGiaHT(int maHT)
        {
            var lay =  ConectionData.dt.HINHTHUCDATPHONGs
                .Where(ht => ht.MAHT == maHT)
                .Select(ht => ht.GIA).SingleOrDefault();
            return (double)lay;
        }
    }
}
