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
    public partial class frmInSanPham : Form
    {
        public frmInSanPham()
        {
            InitializeComponent();
        }
        BUS_SanPham busSanPham = new BUS_SanPham();
        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLoaiSP();
            crpInSanPham crpInSanPham = new crpInSanPham();
            crpInSanPham.SetDataSource(busSanPham.InSanPham(Convert.ToInt32(cbLoaiSP.SelectedValue)));
            this.crystalReportViewer1.ReportSource = crpInSanPham;

        }

        private void frmInSanPham_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = busSanPham.XemDuLieu();
            loadLoaiSP();
        }
        void loadLoaiSP()
        {
            cbLoaiSP.DisplayMember = "TENLOAI";
            cbLoaiSP.ValueMember = "MALOAI";
        }
    }
}
