using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        public bool CheckTK(string tk,string mk)
        {
            var check = ConectionData.dt.TKKHACHSANs
                .Where(c => c.TAIKHOAN ==  tk && c.MATKHAU == mk)
                .Select(c => c.TAIKHOAN).Any();
            return check;
        }
    }
}
