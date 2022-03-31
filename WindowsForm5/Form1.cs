using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_ekle.Text;
            listBox1.Items.Add(gun);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekGun = listBox1.SelectedItem.ToString();

            listBox1.Items.Remove(silinecekGun);
        }

        private void btn_countBul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listbox count değeri : " + listBox1.Items.Count.ToString());
;       }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Listbox temizlendi");
        }
    }
}
