using BUS;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucText : DevExpress.XtraEditors.XtraUserControl
    {
        public ucText()
        {
            InitializeComponent();

        }
        BUS_Tang busTang = new BUS_Tang();
        BUS_Phong busPhong = new BUS_Phong();
        Panel panel;
        string maKS,maPhong;
        private void ucText_Load(object sender, EventArgs e)
        {

            List<DTO_Tang> tang = busTang.Xem();
            int viTri = 0;

            var lables = tablePanel1.Controls.OfType<Label>();
            var stackPanels = tablePanel1.Controls.OfType<StackPanel>();
            
            foreach (var lable in lables)
            {
                DTO_Tang dtoTang = tang[viTri];
                lable.Text = dtoTang.Lau;
                StackPanel stackPanel = stackPanels.ElementAtOrDefault(viTri);
                stackPanel.AutoScroll = true;
                List<DTO_Phong> phong = busTang.CheckTang(dtoTang.MaTang);
                foreach (var item in phong)
                {
                    string[] arr = new string[] {item.MaKS,item.MaPhong};
                    panel = new Panel();
                    panel.Width = 200;
                    panel.Height = 100;
                    panel.Tag = arr;
                    panel.ContextMenuStrip = contextMenuStrip1;
                    this.panel.MouseUp += new MouseEventHandler(this.mouseUp);
                    Label tenPhong = new Label();
                    tenPhong.Text = item.TenPhong;
                    tenPhong.Dock = DockStyle.Top;
                    tenPhong.TextAlign = ContentAlignment.MiddleLeft;
                    tenPhong.Height = 20;
                    panel.Controls.Add(tenPhong);
                    stackPanel.Controls.Add(panel);
                    if (busPhong.CheckPhong(item.MaPhong))
                    {
                        panel.BackColor = Color.Aqua;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                }
                viTri++;
                
            }
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                Panel p = sender as Panel;
                string[] arr = (string[])p.Tag;
                maKS = arr[0];
                maPhong = arr[1];
            }
        }
        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong phong = new frmPhong(maKS, maPhong);
            phong.StartPosition = FormStartPosition.CenterParent;
            phong.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
