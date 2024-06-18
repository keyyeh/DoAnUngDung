using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemTang : Form
    {
        public frmThemTang()
        {
            InitializeComponent();
        }
        BUS_Tang busTang = new BUS_Tang();
        BUS_Phong busPhong = new BUS_Phong();

        DTO_Tang dtoTang = null;
        DTO_Phong dtoPhong = null;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtoTang == null)
            {
                dtoTang = new DTO_Tang(txtTen.Text);
                busTang.Them(dtoTang);
                List<DTO_Tang> tang = busTang.Xem();
                DTO_Tang lastItem = tang.LastOrDefault();
                int idTang = lastItem.Id;
                int soLuong = int.Parse(txtSoPhong.Text);
                for (int i = 1; i <= soLuong; i++)
                {
                    dtoPhong = new DTO_Phong("KS00000001", idTang,$"{tang.Count}0{i}",2,1,0);
                    busPhong.Them(dtoPhong);
                }
                MessageBox.Show("Tạo thành công");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
