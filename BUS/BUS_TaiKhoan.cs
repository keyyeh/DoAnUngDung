using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan taiKhoan = new DAL_TaiKhoan();
        public bool CheckTK(string tk,string mk)
        {
            return taiKhoan.CheckTK(tk,mk);
        }
    }
}
