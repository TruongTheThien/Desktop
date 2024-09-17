using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienSachCaNhan
{
    public partial class FrmThemChuDe : Form
    {



        public FrmThemChuDe()
        {
            InitializeComponent();
        }

     
        

        private void bntThem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
