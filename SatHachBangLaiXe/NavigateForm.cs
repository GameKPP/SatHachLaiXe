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
    public partial class NavigateForm : MetroFramework.Forms.MetroForm
    {
        public NavigateForm()
        {
            InitializeComponent();
        }

        private void NavigateForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMetroInfoAccount_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())//Open main form and hide login form
            {
                frm.ShowDialog();
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            using (FrmThi frm = new FrmThi())//Open main form and hide login form
            {
                frm.ShowDialog();
            }
        }
    }
}
