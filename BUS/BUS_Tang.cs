using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Tang
    {
        DAL_Tang tang = new DAL_Tang();

        public List<DTO_Tang> Xem()
        {
            return tang.Xem();
        }
        public IQueryable XemPhong()
        {
            return tang.XemPhong();
        }
        public List<DTO_Phong> CheckTang(string maTang) 
        {
            return tang.CheckTang(maTang);
        }
        public string LayTenTang(string maTang)
        {
            return tang.LayTenTang(maTang);
        }

    }
}
