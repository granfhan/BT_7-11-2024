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

namespace BT_7_11_2024
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi conn = new KetNoi();
        private void SimThe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Sim ORDER BY NgayKichHoat";
            DataSet ds = conn.LayDuLieu(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                SimThe.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }
    }
}

    class KetNoi
    {
    // Chuỗi kết nối đến SQL Server
    string conStr = @"Data Source=DESKTOP-075MA7I;Initial Catalog=SimThe;Integrated Security=True;Encrypt=False";
    SqlConnection conn;

        // Constructor để khởi tạo SqlConnection
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }

        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                // Mở kết nối trước khi sử dụng
                conn.Open();

                // Tạo DataSet để lưu dữ liệu
                DataSet ds = new DataSet();

                // Tạo SqlDataAdapter với truy vấn và kết nối
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);

                // Đổ dữ liệu vào DataSet
                da.Fill(ds);

                // Đóng kết nối sau khi lấy dữ liệu
                conn.Close();

                return ds;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi và đóng kết nối nếu mở
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return null;
            }
        }

        public bool ThucThi(string truyvan)
        {
            try
            {
                // Mở kết nối trước khi thực thi lệnh
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);

                // Thực thi lệnh SQL
                int r = cmd.ExecuteNonQuery();

                // Đóng kết nối sau khi thực thi
                conn.Close();

                return r > 0;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi và đóng kết nối nếu mở
                MessageBox.Show("Lỗi khi thực thi lệnh: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return false;
            }
        }
    
}