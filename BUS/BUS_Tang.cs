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
    public class BUS_Tang
    {
        DAL_Tang tang = new DAL_Tang();
        public DTO_Tang Lay1Tang(int maTang)
        {
            return tang.Lay1Tang(maTang);
        }
        public List<DTO_Tang> Xem()
        {
            return tang.Xem();
        }
        public DataTable XemPhong()
        {
            return tang.XemPhong();
        }
        public List<DTO_Phong> CheckTang(int maTang,int maLP) 
        {
            return tang.CheckTang(maTang,maLP);
        }
        public string LayTenTang(int maTang)
        {
            return tang.LayTenTang(maTang);
        }
        public int Them(DTO_Tang t)
        {
            return tang.Them(t);
        }
        public int Sua(DTO_Tang t)
        {
            return tang.Sua(t);
        }
        public int Xoa(int maTang)
        {
            return tang.Xoa(maTang);
        }
    }
}
