namespace GUI
{
    partial class ucText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhậnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chưaDọnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐangSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậnPhòngToolStripMenuItem,
            this.chưaDọnPhòngToolStripMenuItem,
            this.phòngĐangSửaToolStripMenuItem,
            this.xóaPhòngToolStripMenuItem,
            this.sửaThôngTinToolStripMenuItem,
            this.thêmPhòngMớiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 148);
            // 
            // nhậnPhòngToolStripMenuItem
            // 
            this.nhậnPhòngToolStripMenuItem.Name = "nhậnPhòngToolStripMenuItem";
            this.nhậnPhòngToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.nhậnPhòngToolStripMenuItem.Text = "Nhận phòng";
            this.nhậnPhòngToolStripMenuItem.Click += new System.EventHandler(this.nhậnPhòngToolStripMenuItem_Click);
            // 
            // chưaDọnPhòngToolStripMenuItem
            // 
            this.chưaDọnPhòngToolStripMenuItem.Name = "chưaDọnPhòngToolStripMenuItem";
            this.chưaDọnPhòngToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.chưaDọnPhòngToolStripMenuItem.Text = "Chưa dọn phòng";
            // 
            // phòngĐangSửaToolStripMenuItem
            // 
            this.phòngĐangSửaToolStripMenuItem.Name = "phòngĐangSửaToolStripMenuItem";
            this.phòngĐangSửaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.phòngĐangSửaToolStripMenuItem.Text = "Phòng đang sửa";
            // 
            // xóaPhòngToolStripMenuItem
            // 
            this.xóaPhòngToolStripMenuItem.Name = "xóaPhòngToolStripMenuItem";
            this.xóaPhòngToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.xóaPhòngToolStripMenuItem.Text = "Xóa phòng";
            this.xóaPhòngToolStripMenuItem.Click += new System.EventHandler(this.xóaPhòngToolStripMenuItem_Click);
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.sửaThôngTinToolStripMenuItem.Text = "Sửa thông tin";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // thêmPhòngMớiToolStripMenuItem
            // 
            this.thêmPhòngMớiToolStripMenuItem.Name = "thêmPhòngMớiToolStripMenuItem";
            this.thêmPhòngMớiToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.thêmPhòngMớiToolStripMenuItem.Text = "Thêm phòng mới";
            this.thêmPhòngMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmPhòngMớiToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảPhòngToolStripMenuItem,
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(254, 80);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1329, 998);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // thêmSảnPhẩmVàDịchVụToolStripMenuItem
            // 
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem.Name = "thêmSảnPhẩmVàDịchVụToolStripMenuItem";
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem.Text = "Thêm sản phẩm và dịch vụ";
            this.thêmSảnPhẩmVàDịchVụToolStripMenuItem.Click += new System.EventHandler(this.thêmSảnPhẩmVàDịchVụToolStripMenuItem_Click);
            // 
            // ucText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucText";
            this.Size = new System.Drawing.Size(1329, 998);
            this.Load += new System.EventHandler(this.ucText_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chưaDọnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngĐangSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngMớiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem thêmSảnPhẩmVàDịchVụToolStripMenuItem;
    }
}
