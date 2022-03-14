using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_Week_4
{
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }

        public static int counter = 0;
        public static int counter2 = 11;
        public static string[] arrayNama = new string[counter2];
        public static string[] arrayAlamat = new string[counter2];
        public static string[] arrayNoTelp = new string[counter2];

        private void TxtBoxInputNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            counter += 1;
            arrayNama[counter - 1] = TxtBoxInputNama.Text;
            arrayAlamat[counter - 1] = TxtBoxInputAlamat.Text;
            arrayNoTelp[counter - 1] = TxtBoxInputNoTelp.Text;
            TxtBoxInputNama.Clear();
            TxtBoxInputAlamat.Clear();
            TxtBoxInputNoTelp.Clear();
            if (counter > 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
        }
        private void BtnLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData newForm = new FormTampilanData();
            newForm.Show();
            this.Visible = false;
        }
    }
}