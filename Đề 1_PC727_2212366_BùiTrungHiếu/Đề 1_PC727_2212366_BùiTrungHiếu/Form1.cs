using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đề_1_PC727_2212366_BùiTrungHiếu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCTDT();
        }
        void LoadCTDT()
        {
            string connectionString = "server = PC727; database = QLDKHP; Integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ChuongTrinhDT";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            conn.Open();
            adapter.Fill(table);
            conn.Close();
            conn.Dispose();
            cbbCTDT.DataSource = table; 
            cbbCTDT.DisplayMember = "TenCTDT";
            cbbCTDT.ValueMember = "MaCTDT";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtSubjectId.Text == null)
            {
                AddSubject();
            }

            UpdateSubject();  
            
            
        }

        private void AddSubject()
        {
            string connectionString = "server = PC727; database = QLDKHP; Integrated security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXECUTE InsertSubject @mamh, @tenmh, @sotc, @mactdt  ";
            cmd.Parameters.Add("@mamh", SqlDbType.Char,10);
            cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@sotc", SqlDbType.Int);
            cmd.Parameters.Add("@mactdt", SqlDbType.Int);

            cmd.Parameters["@mamh"].Direction = ParameterDirection.Output;

            cmd.Parameters["@tenmh"].Value = txtSubjectName.Text;
            cmd.Parameters["@sotc"].Value = nudSoTC.Text;
            cmd.Parameters["@mactdt"].Value = cbbCTDT.SelectedValue;

            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                string subjectID = cmd.Parameters["@mamh"].Value.ToString();
                MessageBox.Show("Thêm môn học thành công, có mã id : " + subjectID, "Message");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("False");
            }    

        }

        private void UpdateSubject()
        {
            

        }
    }
}
