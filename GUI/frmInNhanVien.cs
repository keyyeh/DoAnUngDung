using GUI.DataHoaDonTableAdapters;
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
    public partial class frmInNhanVien : Form
    {
        public frmInNhanVien()
        {
            InitializeComponent();
        }

        private void frmInNhanVien_Load(object sender, EventArgs e)
        {
            NHANVIENTableAdapter adapter = new NHANVIENTableAdapter();
            DataTable dt = adapter.GetData();
            crpNhanVien nhanVien = new crpNhanVien();
            nhanVien.SetDataSource(dt);
            crystalReportViewer1.ReportSource = nhanVien;
        }
    }
}
