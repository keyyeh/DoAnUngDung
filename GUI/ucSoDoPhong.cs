using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

        private void ucText_Load(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in tablePanel1.Rows)
            {
                tong++;
            }
            MessageBox.Show(tong.ToString());
        }
    }
}
