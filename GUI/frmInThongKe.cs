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
    public partial class frmInThongKe : Form
    {
        private DateTime tuNgay, denNgay;
        private int viTri;
        private string flag;
        public frmInThongKe(DateTime tuNgay,DateTime denNgay, string flag,int viTri)
        {
            InitializeComponent();
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
            this.flag = flag;
            this.viTri = viTri;
        }
        BUS_HoaDon hoaDon = new BUS_HoaDon();
        private void frmInThongKe_Load(object sender, EventArgs e)
        {
            if (flag == "Tuan")
            {
                crpThongKe thongKe = new crpThongKe();
                thongKe.SetDataSource(hoaDon.BaoCaoTheoKhoangNgay(tuNgay, denNgay));
                this.crystalReportViewer1.ReportSource = thongKe;
            }
            else
            {
                crpThongKe thongKe = new crpThongKe();
                thongKe.SetDataSource(hoaDon.BaoCaoTheoKhoangNgay(viTri));
                this.crystalReportViewer1.ReportSource = thongKe;
            }
           
        }
    }
}
