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

namespace QuanLiThuVienSachCaNhan
{
    public partial class Frm_ChoMuon : Form
    {

        

        public Frm_ChoMuon()
        {
            InitializeComponent();
        }
        public void SetSach(string maSach, string tenSach)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
     
        }
        public (string, string, string, string, string, int, DateTime, DateTime) LayTTSach()
        {
            int TinhTrang = rd_muon.Checked ? 0 : 1;
            DateTime NgayTra = dtpNgayTra.Value;
            DateTime NgayMuon = dtpNgayMuon.Value;

            return (txtMaSach.Text, txtTenSach.Text, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text, TinhTrang, NgayMuon, NgayTra);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  
            this.Close();
        }
    }
}
