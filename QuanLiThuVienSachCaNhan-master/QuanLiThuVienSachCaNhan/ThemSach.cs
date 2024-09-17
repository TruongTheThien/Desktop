using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienSachCaNhan
{
    public partial class ThemSach : Form
    {
      
        string connectstring = @"Data Source = DESKTOP-9S67OTJ ;Initial Catalog = QLSachCaNhan; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dtbook = new DataTable();

        public ThemSach()
        {

            InitializeComponent();
            LoadMaChuDe();
        }
        private void LoadMaChuDe()
        {

            string query = "SELECT MaChuDe, Name FROM Category";

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Populate ComboBox with MaChuDe and display Name
                        cbbChuDe.DisplayMember = "Name";
                        cbbChuDe.ValueMember = "MaChuDe";
                        cbbChuDe.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu mã chủ đề: " + ex.Message);
            }
        }

        private void bnt_themsach_Click(object sender, EventArgs e)
        {
           /* string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            string viTri = txtViTri.Text;
            int maChuDe = int.Parse(txtMaChuDe.Text);
            string tenChuDe = cbbChuDe.Text; 

            string query = "INSERT INTO Book (maSach, tenSach, tacGia, viTri, chuDe,maChuDe) " +
                      "VALUES (@maSach, @tenSach, @tacGia, @viTri, @chuDe,@maChuDe)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@maSach", maSach);
                        cmd.Parameters.AddWithValue("@tenSach", tenSach);
                        cmd.Parameters.AddWithValue("@tacGia", tacGia);
                        cmd.Parameters.AddWithValue("@viTri", viTri);
                        cmd.Parameters.AddWithValue("@chuDe", tenChuDe);
                        cmd.Parameters.AddWithValue("@maChuDe", maChuDe);

                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sách thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message);
            }*/
        }

        private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbbChuDe.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbbChuDe.SelectedItem;
                txtMaChuDe.Text = selectedRow["MaChuDe"].ToString(); // Hiển thị mã chủ đề trong TextBox
            }*/
        }
    }
}
