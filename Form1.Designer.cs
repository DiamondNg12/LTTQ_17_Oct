namespace LTTQ_17_Oct
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtMaSV = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtKhoa = new TextBox();
            label5 = new Label();
            txtLop = new TextBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtNgaySinh = new MaskedTextBox();
            label7 = new Label();
            dataGridView = new DataGridView();
            btnMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 63);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(157, 60);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(147, 23);
            txtMaSV.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(157, 94);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(147, 23);
            txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 68);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 1;
            label4.Text = "Khoa";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(581, 65);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(147, 23);
            txtKhoa.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 97);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 1;
            label5.Text = "Lớp";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(581, 94);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(147, 23);
            txtLop.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(478, 130);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(581, 127);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(147, 23);
            txtDiaChi.TabIndex = 2;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Cursor = Cursors.Cross;
            txtNgaySinh.Location = new Point(157, 130);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(147, 23);
            txtNgaySinh.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 135);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 4;
            label7.Text = "Ngày sinh";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 172);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(776, 220);
            dataGridView.TabIndex = 5;
            // 
            // btnMoi
            // 
            btnMoi.Location = new Point(37, 415);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(75, 23);
            btnMoi.TabIndex = 6;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(157, 415);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(273, 415);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(388, 415);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(513, 415);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(69, 23);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(628, 415);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnMoi);
            Controls.Add(dataGridView);
            Controls.Add(label7);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtLop);
            Controls.Add(txtKhoa);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaSV;
        private Label label3;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtKhoa;
        private Label label5;
        private TextBox txtLop;
        private Label label6;
        private TextBox txtDiaChi;
        private MaskedTextBox txtNgaySinh;
        private Label label7;
        private DataGridView dataGridView;
        private Button btnMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
    }
}