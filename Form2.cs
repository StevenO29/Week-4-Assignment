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
    public partial class FormTampilanData : Form
    {
        public FormTampilanData()
        {
            InitializeComponent();
        }

        public static int counter3 = 0;

        public void FormTampilanData_Load(object sender, EventArgs e)
        {
            TxtBoxTampilanNama.Text = FormPenambahanData.arrayNama[0];
            TxtBoxTampilAlamat.Text = FormPenambahanData.arrayAlamat[0];
            TxtBoxTampilNoTelp.Text = FormPenambahanData.arrayNoTelp[0];
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormPenambahanData backOpenForm = new FormPenambahanData();
            backOpenForm.Show();
            this.Visible = false;
        }

        private void BtnPrevData_Click(object sender, EventArgs e)
        {
            counter3--;
            if (counter3 < 0)
            {
                MessageBox.Show("Data sudah data pertama!");
                counter3++;
            }
            TxtBoxTampilanNama.Text = FormPenambahanData.arrayNama[counter3];
            TxtBoxTampilAlamat.Text = FormPenambahanData.arrayAlamat[counter3];
            TxtBoxTampilNoTelp.Text = FormPenambahanData.arrayNoTelp[counter3];
        }

        private void BtnNextData_Click(object sender, EventArgs e)
        {
            counter3++;
            if (counter3 >= 10)
                MessageBox.Show("Data sudah data terakhir!");
            else if (counter3 > FormPenambahanData.counter - 1)
            {
                MessageBox.Show("Data sudah data terakhir!");
                counter3--;
            }
            TxtBoxTampilanNama.Text = FormPenambahanData.arrayNama[counter3];
            TxtBoxTampilAlamat.Text = FormPenambahanData.arrayAlamat[counter3];
            TxtBoxTampilNoTelp.Text = FormPenambahanData.arrayNoTelp[counter3];
        }
    }
}
