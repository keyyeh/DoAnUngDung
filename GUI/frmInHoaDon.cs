using BUS;
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
    public partial class frmInHoaDon : Form
    {
        private string sdt;
        private int maPhong;
        public frmInHoaDon(string sdt,int maPhong)
        {
            InitializeComponent();
            this.sdt = sdt;
            this.maPhong = maPhong;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            BUS_DatPhong datPhong = new BUS_DatPhong();
            crpInPhieuXuat inHD = new crpInPhieuXuat();
            inHD.SetDataSource(datPhong.InHoaDon(sdt,maPhong));

            crystalReportViewer1.ReportSource = inHD;
        }
    }
}
