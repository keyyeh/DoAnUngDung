using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phong
    {
        private string maKS,tenPhong;
        private int maLoaiP,maHT,sucChua,maPhong, maTang;

        public DTO_Phong()
        {
        }
        public DTO_Phong(string maKS, int maTang, string tenPhong, int maLoaiP, int maHT, int sucChua)
        {
            this.maKS = maKS;
            this.maTang = maTang;
            this.tenPhong = tenPhong;
            this.maLoaiP = maLoaiP;
            this.maHT = maHT;
            this.sucChua = sucChua;
        }
        public DTO_Phong(int maPhong, string maKS, int maTang, string tenPhong, int maLoaiP, int maHT, int sucChua)
        {
            this.maPhong = maPhong;
            this.maKS = maKS;
            this.maTang = maTang;
            this.tenPhong = tenPhong;
            this.maLoaiP = maLoaiP;
            this.maHT = maHT;
            this.sucChua = sucChua;
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string MaKS { get => maKS; set => maKS = value; }
        public int MaTang { get => maTang; set => maTang = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int MaLoaiP { get => maLoaiP; set => maLoaiP = value; }
        public int MaHT { get => maHT; set => maHT = value; }
        public int SucChua { get => sucChua; set => sucChua = value; }
    }
}
