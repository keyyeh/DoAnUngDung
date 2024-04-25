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
    public partial class ucKhachSan : UserControl
    {
        Timer timer = new Timer();
        public ucKhachSan()
        {
            InitializeComponent();
            InitializeClock();
        }
        DTO_Phong dtoPhong;
        BUS_Phong busPhong = new BUS_Phong();
        private void ucKhachSan_Load(object sender, EventArgs e)
        {
            List<DTO_Phong> xem = busPhong.LayDuLieu();

            foreach (var item in xem)
            {
                PictureBox pic = new PictureBox();
                Panel panel = new Panel();
                Label label = new Label();
                pic.Image = Properties.Resources.room;
                pic.Dock = DockStyle.Top;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Height = 80;
                label.AutoSize = false;
                label.Text = item.TenPhong;
                label.Dock = DockStyle.Bottom;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Height = 20;
                panel.Height = 100;
                panel.Width = 100;
                panel.Controls.Add(pic);
                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);
            }

        }

        private void ucKhachSan_Resize(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void InitializeClock()
        {
            // Set timer interval to 1 second
            timer.Interval = 1000;
            // Add event handler for tick event
            timer.Tick += Timer_Tick;
            // Start the timer
            timer.Start();
        }
    }
}
