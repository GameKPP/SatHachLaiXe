using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    public partial class FrmXemDapAn : MetroFramework.Forms.MetroForm
    {
        public FrmXemDapAn()
        {
            InitializeComponent();
        }

        private void FrmXemDapAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sATHACHBANGLAI1DataSet4.Xem_Dap_An_Sai' table. You can move, or remove it, as needed.
            this.xem_Dap_An_SaiTableAdapter.Fill(this.sATHACHBANGLAI1DataSet4.Xem_Dap_An_Sai);
            // TODO: This line of code loads data into the 'sATHACHBANGLAI1DataSet1.Xem_Dap_An' table. You can move, or remove it, as needed.
            this.xem_Dap_AnTableAdapter1.Fill(this.sATHACHBANGLAI1DataSet1.Xem_Dap_An);
            // TODO: This line of code loads data into the 'sATHACHBANGLAI1DataSet.Xem_Dap_An' table. You can move, or remove it, as needed.
            int count1= metroGrid1.Rows.Count;
            int count2 = metroGrid2.Rows.Count;

            lbCauDung.Text = "" +count1;
            lbCauSai.Text =  "" +count2;

        }

        private void btnThoatThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
