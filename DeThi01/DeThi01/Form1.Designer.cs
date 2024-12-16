namespace DeThi01
{
    partial class Form1
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
            this.lvSinhvien = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bntKLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSinhvien
            // 
            this.lvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.TenSV,
            this.NgaySinh,
            this.Lop});
            this.lvSinhvien.HideSelection = false;
            this.lvSinhvien.Location = new System.Drawing.Point(53, 244);
            this.lvSinhvien.Name = "lvSinhvien";
            this.lvSinhvien.Size = new System.Drawing.Size(776, 175);
            this.lvSinhvien.TabIndex = 8;
            this.lvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lvSinhvien.View = System.Windows.Forms.View.Details;
            this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "Mã SV";
            this.MSSV.Width = 134;
            // 
            // TenSV
            // 
            this.TenSV.Text = "Họ Tên";
            this.TenSV.Width = 244;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Lớp";
            this.NgaySinh.Width = 249;
            // 
            // Lop
            // 
            this.Lop.Text = "Ngày Sinh";
            this.Lop.Width = 145;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(123, 173);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(76, 65);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.bntKLuu);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(214, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(524, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 27);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bntKLuu
            // 
            this.bntKLuu.Location = new System.Drawing.Point(420, 18);
            this.bntKLuu.Name = "bntKLuu";
            this.bntKLuu.Size = new System.Drawing.Size(98, 27);
            this.bntKLuu.TabIndex = 0;
            this.bntKLuu.Text = "K Lưu";
            this.bntKLuu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(323, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 27);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(219, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 27);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 27);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 27);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(-33, 194);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(150, 22);
            this.txtTim.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.txtHoTenSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(103, 78);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(274, 22);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "L01",
            "L02",
            "L03"});
            this.cbLop.Location = new System.Drawing.Point(507, 68);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(238, 33);
            this.cbLop.TabIndex = 2;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(507, 26);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(238, 30);
            this.txtHoTenSV.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(103, 29);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(274, 30);
            this.txtMaSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.lvSinhvien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSinhvien;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader TenSV;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button bntKLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

