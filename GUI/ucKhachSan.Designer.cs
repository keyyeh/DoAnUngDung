namespace GUI
{
    partial class ucKhachSan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.timeNow = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKS = new System.Windows.Forms.TextBox();
            this.txtMaKS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(864, 661);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnDatPhong);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.timeNow);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(864, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 661);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Trả phòng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(127, 612);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(144, 43);
            this.btnDatPhong.TabIndex = 18;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatPhong.Location = new System.Drawing.Point(0, 661);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.RowHeadersWidth = 51;
            this.dgvDatPhong.RowTemplate.Height = 24;
            this.dgvDatPhong.Size = new System.Drawing.Size(1750, 339);
            this.dgvDatPhong.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Giờ hiện tại";
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.Color.Red;
            this.timeNow.Location = new System.Drawing.Point(169, 541);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(64, 19);
            this.timeNow.TabIndex = 15;
            this.timeNow.Text = "...........";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(588, 496);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 496);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ngày trả phòng*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày đặt phòng*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtCCCD);
            this.groupBox3.Controls.Add(this.rtbDiaChi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(442, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 389);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin cá nhân";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 27);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(144, 114);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(257, 27);
            this.txtSDT.TabIndex = 12;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(144, 52);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(257, 27);
            this.txtCCCD.TabIndex = 11;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(6, 318);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(395, 59);
            this.rtbDiaChi.TabIndex = 5;
            this.rtbDiaChi.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD/CMND*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số điện thoại*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email*:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtTenKS);
            this.groupBox2.Controls.Add(this.txtMaKS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 389);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Location = new System.Drawing.Point(156, 235);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(220, 27);
            this.txtTenPhong.TabIndex = 14;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(156, 173);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(220, 27);
            this.txtMaPhong.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tên phòng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "Mã phòng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(156, 350);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(220, 27);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(156, 286);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(220, 27);
            this.txtMaKH.TabIndex = 9;
            // 
            // txtTenKS
            // 
            this.txtTenKS.Enabled = false;
            this.txtTenKS.Location = new System.Drawing.Point(156, 114);
            this.txtTenKS.Name = "txtTenKS";
            this.txtTenKS.Size = new System.Drawing.Size(220, 27);
            this.txtTenKS.TabIndex = 8;
            // 
            // txtMaKS
            // 
            this.txtMaKS.Enabled = false;
            this.txtMaKS.Location = new System.Drawing.Point(156, 52);
            this.txtMaKS.Name = "txtMaKS";
            this.txtMaKS.Size = new System.Drawing.Size(220, 27);
            this.txtMaKS.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên khách sạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã khách sạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng*:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG ĐẶT PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1750, 661);
            this.panel2.TabIndex = 18;
            // 
            // ucKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDatPhong);
            this.Name = "ucKhachSan";
            this.Size = new System.Drawing.Size(1750, 1000);
            this.Load += new System.EventHandler(this.ucKhachSan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKS;
        private System.Windows.Forms.TextBox txtMaKS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private System.Windows.Forms.Panel panel2;
    }
}
