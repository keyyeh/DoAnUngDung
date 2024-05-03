using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Phong
    {
        DAL_Phong phong = new DAL_Phong();
        public List<DTO_Phong> LayDuLieu()
        {
            return phong.LayDuLieu();
        }
        public IQueryable Xem()
        {
            return phong.Xem();
        }

        public bool CheckPhong(string maPhong)
        {
            return phong.CheckPhong(maPhong);
        }
        public int Them(DTO_Phong p)
        {
            return phong.Them(p);
        }
        public int Sua(DTO_Phong p)
        {
            return phong.Sua(p);
        }
        public int Xoa(string maP)
        {
            return phong.Xoa(maP);
        }

        public DTO_Phong Lay1Phong(string maKS, string maPhong)
        {
            return phong.Lay1Phong(maKS,maPhong);
        }
    }
}
