namespace ControlLibrary.UC.Display
{
    partial class UC_UserProfile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_tool = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV_ThongKe = new System.Windows.Forms.DataGridView();
            this.cbb_KieuThongKe = new System.Windows.Forms.ComboBox();
            this.cbb_Thang = new System.Windows.Forms.ComboBox();
            this.cbb_Quy = new System.Windows.Forms.ComboBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_tool);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 73);
            this.panel2.TabIndex = 10;
            // 
            // panel_tool
            // 
            this.panel_tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tool.Location = new System.Drawing.Point(0, 70);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(847, 3);
            this.panel_tool.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // dataGV_ThongKe
            // 
            this.dataGV_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_ThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dataGV_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGV_ThongKe.Location = new System.Drawing.Point(30, 181);
            this.dataGV_ThongKe.Name = "dataGV_ThongKe";
            this.dataGV_ThongKe.RowHeadersVisible = false;
            this.dataGV_ThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_ThongKe.Size = new System.Drawing.Size(789, 250);
            this.dataGV_ThongKe.TabIndex = 11;
            // 
            // cbb_KieuThongKe
            // 
            this.cbb_KieuThongKe.FormattingEnabled = true;
            this.cbb_KieuThongKe.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo quý"});
            this.cbb_KieuThongKe.Location = new System.Drawing.Point(62, 117);
            this.cbb_KieuThongKe.Name = "cbb_KieuThongKe";
            this.cbb_KieuThongKe.Size = new System.Drawing.Size(161, 21);
            this.cbb_KieuThongKe.TabIndex = 12;
            this.cbb_KieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_KieuThongKe_SelectedIndexChanged);
            // 
            // cbb_Thang
            // 
            this.cbb_Thang.Enabled = false;
            this.cbb_Thang.FormattingEnabled = true;
            this.cbb_Thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Thán 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbb_Thang.Location = new System.Drawing.Point(449, 117);
            this.cbb_Thang.Name = "cbb_Thang";
            this.cbb_Thang.Size = new System.Drawing.Size(163, 21);
            this.cbb_Thang.TabIndex = 13;
            // 
            // cbb_Quy
            // 
            this.cbb_Quy.Enabled = false;
            this.cbb_Quy.FormattingEnabled = true;
            this.cbb_Quy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbb_Quy.Location = new System.Drawing.Point(656, 117);
            this.cbb_Quy.Name = "cbb_Quy";
            this.cbb_Quy.Size = new System.Drawing.Size(163, 21);
            this.cbb_Quy.TabIndex = 14;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(697, 449);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(122, 45);
            this.btn_ThongKe.TabIndex = 15;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "MaNV";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "DiaChi";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongMatHang";
            this.Column5.HeaderText = "Tổng mặt hàng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongTien";
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayLap";
            this.Column7.HeaderText = "Ngày lập";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayGiao";
            this.Column8.HeaderText = "NgayGiao";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // label_ketqua
            // 
            this.label_ketqua.AutoSize = true;
            this.label_ketqua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ketqua.Location = new System.Drawing.Point(100, 449);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(0, 21);
            this.label_ketqua.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(261, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // UC_UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.cbb_Quy);
            this.Controls.Add(this.cbb_Thang);
            this.Controls.Add(this.cbb_KieuThongKe);
            this.Controls.Add(this.dataGV_ThongKe);
            this.Controls.Add(this.panel2);
            this.Name = "UC_UserProfile";
            this.Size = new System.Drawing.Size(847, 542);
            this.Load += new System.EventHandler(this.UC_UserProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_tool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGV_ThongKe;
        private System.Windows.Forms.ComboBox cbb_KieuThongKe;
        private System.Windows.Forms.ComboBox cbb_Thang;
        private System.Windows.Forms.ComboBox cbb_Quy;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
