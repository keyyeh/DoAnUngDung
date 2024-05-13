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
    public class BUS_DatMon
    {
        DAL_DatMon datMon = new DAL_DatMon();
        public int Them(DTO_DatMon dm)
        {
            return datMon.Them(dm);
        }
        public DataTable LayDuLieu(string maPhong)
        {
            return datMon.LayDuLieu(maPhong);
        }
        public int Xoa(string maPhong)
        {
            return datMon.Xoa(maPhong);
        }
    }
}
