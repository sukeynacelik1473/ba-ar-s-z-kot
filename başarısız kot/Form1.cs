using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace başarısız_kot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = txtAd.Text;
            int sayac = 0;

            for (int i = 0; i < lbAdlar.Items.Count; i++)
            {
                if(aranan == lbAdlar.Items[i].ToString())
                {
                    sayac++;
                }
            }
            if(sayac > 0)
            {
                MessageBox.Show (sayac + "tane var");
            }
            else
            {
                MessageBox.Show ( sayac + " tane yok");
            }
        }
    }
}
