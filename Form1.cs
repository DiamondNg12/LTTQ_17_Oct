using System.Diagnostics;

namespace LTTQ_17_Oct
{
    public partial class Form1 : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dataGridView.DataSource = db.data("tblSinhVien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query;
            query = "Update tblSinhVien " +
                "set HoTen = N'" + txtHoTen.Text + "', " +
                "NgaySinh = N'" + txtNgaySinh.Text + "', " +
                "Khoa = N'" + txtKhoa.Text + "', " +
                "Lop = N'" + txtLop.Text + "', " +
                "DiaChi = N'" + txtDiaChi.Text + "'" +
                "where MaSV = N'" + txtMaSV + "'";
            db.executeQuery(query);
            this.LoadDataGridView();
        }
    }
}