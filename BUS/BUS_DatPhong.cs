using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DatPhong
    {
        DAL_DatPhong dPhong = new DAL_DatPhong();

        public IQueryable Xem(string maKS)
        {
            return dPhong.Xem(maKS);
        }
        public int Them(DTO_DatPhong datPhong)
        {
            return dPhong.Them(datPhong);
        }
    }
}
