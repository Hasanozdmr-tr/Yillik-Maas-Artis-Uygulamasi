using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YillikMaasArtisUygulamasi
{
    public partial class Form1 : Form
    {
        int maas=0;
        int yillikartis = 0;
        int vade = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            maas = Convert.ToInt32(dudMaas.Text);
            yillikartis = Convert.ToInt32(dudYillikArtis.Text);
            vade = Convert.ToInt32(dudVadesi.Text);
            string result = Convert.ToString(Hesapla(maas, yillikartis, vade));
            
            MessageBox.Show(result);
        }

        public int Hesapla(double a, double b, double c)
        {
            int sonuc;
            for (int i=1;i<=c;i++ )
            {
                double tmp = 0;
                tmp = a * (1 + b/100);
                a = tmp;
                
              
                
            }
            sonuc = Convert.ToInt32(a);


            return sonuc;
        }

        private void dudMaas_SelectedItemChanged(object sender, EventArgs e)
        {
        //    (Convert.ToString(dudMaas.Text)).Clear();
            
        }
    }
}
