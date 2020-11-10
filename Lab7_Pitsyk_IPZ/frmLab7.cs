using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Pitsyk_IPZ
{
    public partial class frmLab7 : Form
    {
        public int i;
        public frmLab7()
        {
            InitializeComponent();
        }

        private void frmLab7_Load(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Піцик Георгій \n" + System.DateTime.Now, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Дійсно закрити додаток?", "Закриття додатка", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_using_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
