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
        public DTO_ThongTinDatPhong InPhieu(int maPhong)
        {
            return dPhong.InPhieu(maPhong);
        }
        public double TongTien(int maPhong)
        {
            return dPhong.TongTien(maPhong);
        }
        public int Xoa(int maPhong)
        {
            return dPhong.Xoa(maPhong);
        }
        public DataTable LayDuLieu(int maPhong)
        {
            return dPhong.LayDuLieu(maPhong);
        }
        public double TongTien(string maKS, int maPhong)
        {
            return dPhong.TongTien(maKS, maPhong);
        }
        public double LayGiaPhong(int maPhong)
        {
            return dPhong.LayGiaPhong(maPhong);
        }
        public double TongHoaDon(string sdt, int maPhong, string maKS)
        {
            return dPhong.TongHoaDon(sdt, maPhong, maKS);
        }
        public DataTable InHoaDon(string sdt, int maPhong)
        {
            return dPhong.InHoaDon(sdt, maPhong);
        }
        public DTO_DatPhong Lay1DatPhong(int maPhong)
        {
            return dPhong.Lay1DatPhong(maPhong);
        }
        public int Sua(DTO_DatPhong datPhong)
        {
            return dPhong.Sua(datPhong);
        }
    }
}
