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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        BUS_LoaiSP busLoai = new BUS_LoaiSP();
        BUS_SanPham busSanPham = new BUS_SanPham();

        int id,maSanPham;
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            cbLoai.DataSource = busLoai.Xem();
            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmCapNhat cn = new frmCapNhat("editOK");
            cn.ShowDialog();
            frmLoaiSP_Load(sender, e);
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
            id = Convert.ToInt16(cbLoai.SelectedValue);
            dgvSanPham.DataSource = busSanPham.Xem(id);
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                dgvSanPham.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmCapNhat cn = new frmCapNhat(id.ToString(),"updateOK");
            cn.ShowDialog();
            frmLoaiSP_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Ban co muon xoa khong","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                busLoai.Xoa(id);
                frmLoaiSP_Load(sender, e);
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemSanPham frmThemSanPham = new frmThemSanPham(id,"Them");
            frmThemSanPham.StartPosition = FormStartPosition.CenterScreen;
            frmThemSanPham.ShowDialog();
            frmLoaiSP_Load(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int viTri = int.Parse(dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex].Cells["maSP"].Value.ToString());
            frmThemSanPham frmThemSanPham = new frmThemSanPham(viTri, "Sua");
            frmThemSanPham.StartPosition = FormStartPosition.CenterScreen;
            frmThemSanPham.ShowDialog();
            frmLoaiSP_Load(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            busSanPham.Xoa(maSanPham);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int viTri = e.RowIndex;
            if (viTri >= 0)
            {
                maSanPham = int.Parse(dgvSanPham.SelectedColumns[1].ToString());
            }
        }
    }
}
