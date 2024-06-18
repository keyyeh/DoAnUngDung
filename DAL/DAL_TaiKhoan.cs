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
            var check = ConectionData.dt.TKNHANVIENs
                .Where(c => c.TAIKHOAN ==  tk && c.MATKHAU == mk)
                .Select(c => c).Any();
            return check;
        }
        public bool TaoTK(string tk,string mk)
        {
            try
            {
                TKNHANVIEN tKNHANVIEN = new TKNHANVIEN
                {
                    TAIKHOAN = tk,
                    MATKHAU = mk
                };
                ConectionData.dt.TKNHANVIENs.InsertOnSubmit(tKNHANVIEN);
                ConectionData.dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
