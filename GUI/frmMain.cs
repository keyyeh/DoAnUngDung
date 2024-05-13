using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string maKS;
        public frmMain(string maKS)
        {
            InitializeComponent();
            this.maKS = maKS;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucText phong = new ucText();
            phong.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(phong);
            phong.BringToFront();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            ucNhanVien nhanVien = new ucNhanVien(maKS);
            nhanVien.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(nhanVien);
            nhanVien.BringToFront();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            ucText phong = new ucText();
            phong.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(phong);
            phong.BringToFront();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            frmLoaiSP sp = new frmLoaiSP();
            sp.Show();
        }
    }
}
