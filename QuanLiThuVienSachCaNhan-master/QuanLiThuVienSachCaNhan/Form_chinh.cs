using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLiThuVienSachCaNhan
{
    public partial class Form_chinh : Form
    {

        string connectstring = @"Data Source = DESKTOP-9S67OTJ ;Initial Catalog = QLSachCaNhan; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dtsach = new DataTable();
        DataTable dtDSMuon = new DataTable();

        public Form_chinh()
        {
            InitializeComponent();

        }
        private void CustomizeDataGridViewColumns1()
        {
           
            dataGridView1.Columns["IDSach"].HeaderText = "ID Sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
            dataGridView1.Columns["TacGia"].HeaderText = "Tác Giả";
            dataGridView1.Columns["TheLoai"].HeaderText = "Thể Loại";
            dataGridView1.Columns["ViTri"].HeaderText = "Vị Trí";

            dataGridView1.Columns["IDSach"].Width = 100;
            dataGridView1.Columns["TenSach"].Width = 200;
            dataGridView1.Columns["TacGia"].Width = 150;
            dataGridView1.Columns["TheLoai"].Width = 150;
            dataGridView1.Columns["ViTri"].Width = 100;
        }
        private void CustomizeDataGridViewColumns2()
        {

            dataGridView1.Columns["IDSach"].HeaderText = "ID Sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
            dataGridView1.Columns["TacGia"].HeaderText = "Tác Giả";
            dataGridView1.Columns["TheLoai"].HeaderText = "Thể Loại";
            dataGridView1.Columns["ViTri"].HeaderText = "Vị Trí";

            dataGridView1.Columns["IDSach"].Width = 100;
            dataGridView1.Columns["TenSach"].Width = 200;
            dataGridView1.Columns["TacGia"].Width = 150;
            dataGridView1.Columns["TheLoai"].Width = 150;
            dataGridView1.Columns["ViTri"].Width = 100;
        }
        private void LoadSach()
        {
            dtsach = new DataTable();
            dtDSMuon = new DataTable();
            con = new SqlConnection(connectstring);
            string query = @"
            SELECT A.IDSach, A.TenSach, B.TacGia AS TacGia, C.TheLoai AS TheLoai, A.ViTri
            FROM Sach A
            INNER JOIN TacGia B ON A.IDTacGia = B.IDTacGia
            INNER JOIN TheLoai C ON A.IDTheLoai = C.IDTheLoai;";
            try
            {   
                con.Open();
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dtsach);
                dataGridView1.DataSource = dtsach;
                CustomizeDataGridViewColumns1();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDSMuon()
        {
            dtDSMuon = new DataTable();
            con = new SqlConnection(connectstring);
            string query = @"SELECT IDMuon, IDSach, TenSach, HoTen, SDT, ChoMuon, Muon, NgayMuon, NgayTra, DiaChi, DaTra FROM DSMuon";
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dtDSMuon);
                dataGridView2.DataSource = dtDSMuon;
                CustomizeDataGridViewColumns1();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form_chinh_Load(object sender, EventArgs e)
        {
            LoadSach();
            LoadDSMuon();
        }


        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }


        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongke frm = new frm_thongke();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSach addsachForm = new ThemSach();

            addsachForm.ShowDialog();

        }

      

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSach();

        }
       

        private void btnLoc2_Click(object sender, EventArgs e)
        {
           
        }

        private void choMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ hàng đó
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();
                Frm_ChoMuon form2 = new Frm_ChoMuon();
                form2.SetSach(maSach, tenSach);
                if (form2.ShowDialog() == DialogResult.OK)
                {

                    var thongtin = form2.LayTTSach();
                    using (SqlConnection connection = new SqlConnection(connectstring))
                    {
                        string query = "INSERT INTO DSMuon (MaSach, TenSach, HoTen, TinhTrang, NgayMuon, NgayTra, SDT, DiaChi) " +
                          "VALUES (@MaSach, @TenSach, @HoTen, @TinhTrang, @NgayMuon, @NgayTra, @SDT, @DiaChi)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Gán giá trị cho các tham số
                            command.Parameters.AddWithValue("@MaSach", thongtin.Item1);
                            command.Parameters.AddWithValue("@TenSach", thongtin.Item2);
                            command.Parameters.AddWithValue("@HoTen", thongtin.Item3);
                            command.Parameters.AddWithValue("@TinhTrang", thongtin.Item6 != 0 ? 1 : 0);
                            command.Parameters.AddWithValue("@NgayMuon", thongtin.Item7);
                            command.Parameters.AddWithValue("@NgayTra", thongtin.Item8);
                            command.Parameters.AddWithValue("@SDT", thongtin.Item4);
                            command.Parameters.AddWithValue("@DiaChi", thongtin.Item5);

                            try
                            {
                                // Mở kết nối và thực thi câu lệnh
                                connection.Open();
                                int result = command.ExecuteNonQuery();


                                // Kiểm tra kết quả của câu lệnh
                                if (result > 0)
                                {
                                    MessageBox.Show("Thêm thông tin sách thành công!");
                                    LoadSach();
                                    con.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Không thêm được thông tin sách.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng trước.");
                }
            }
        }
        private void ThemChuDeMenustrip_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteSachMuon(int ID)
        {

           
            string query = "DELETE FROM DSMuon WHERE ID = @ID";
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!");
                            LoadSach();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách với mã đã cho.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
            }
        }

        private void xóaSachToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int IDMuon = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteSachMuon(IDMuon);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }
        private void Deletesach(string maSach)
        {
            string query = "DELETE FROM sach WHERE maSach = @maSach";

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!");
                            LoadSach();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách với mã đã cho.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
            }
        }

        private void xoasach1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Deletesach(maSach);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa.");
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }
 
