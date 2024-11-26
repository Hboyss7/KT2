using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đề_1_PC727_2212366_BùiTrungHiếu
{
   
    public partial class QuanLyMonHoc : Form
    {
        DataTable table;
        enum Loai
        {
            All,
            rd2015,
            rd2017,
            rd2020
        }
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            rdAll.Checked = true;
            LoadDSMH(Loai.All);
        }

        private void LoadDSMH(Loai loai)
        {
            string connectionString = "server = PC727; database = QLDKHP; Integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaMH,TenMH,TenCTDT,SoTC FROM MonHoc, ChuongTrinhDT WHERE MonHoc.MaCTĐT = ChuongTrinhDT.MaCTDT";
            if (loai == Loai.rd2015)
            {
                cmd.CommandText += " AND TenCTDT = N'Chương trình đào tạo 2015'";
            }
            if (loai == Loai.rd2017)
            {
                cmd.CommandText += " AND TenCTDT = N'Chương trình đào tạo 2017'";
            }
            if (loai == Loai.rd2020)
            {
                cmd.CommandText += " AND TenCTDT = N'Chương trình đào tạo 2020'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            dgvDSMH.DataSource = table;
            
        }

        private void LoadDSMH2()
        {
            string connectionString = "server = PC727; database = QLDKHP; Integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from MonHoc,ChuongTrinhDT";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            dgvDSMH.DataSource = table;
            
        }


        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSMH(Loai.All);
        }

        private void rd2015_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSMH(Loai.rd2015);
        }

        private void rd2017_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSMH(Loai.rd2017);
        }

        private void rd2020_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSMH(Loai.rd2020);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new Form1();
            dialog.ShowDialog();
            LoadDSMH(Loai.All);
        }

        private void dgvDSMH_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
