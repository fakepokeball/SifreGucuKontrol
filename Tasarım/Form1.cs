using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yilYazi;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnSorgula_Click(object sender, EventArgs e)
        {
            yilYazi = txtYil.Text;

        }
        public static bool artikYilMi(string girilenYil)
        {
            
            bool yilMi=false;

            if(!int.TryParse(girilenYil, out int yil))
            {
                MessageBox.Show("Hatalı Giriş!", "UYARI");
            }
            else
            {
                if (yil >= 0)
                {
                    if(yil%100!=0 && yil % 4 == 0)
                    {
                        yilMi = true;
                    }
                    else if (yil % 400 == 0 && yil%4000!=0)
                    {
                        yilMi=true;
                    }
                    else
                    {
                        yilMi=false;
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!", "UYARI");

                }
            }
            return yilMi;
        }
    }
}
