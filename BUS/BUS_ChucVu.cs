using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChucVu
    {
        DAL_ChucVu chucVu = new DAL_ChucVu();
        public IQueryable Xem()
        {
            return chucVu.Xem();
        }
        public string LayTenCV(string maCV)
        {
            return chucVu.LayTenCV(maCV);
        }
    }
}
