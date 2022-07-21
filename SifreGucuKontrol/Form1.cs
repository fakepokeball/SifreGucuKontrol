using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreGucuKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sifre = "";
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            sifre = txtSifre.Text;
            if (sifre == "")
            {
                lblPower.BackColor = Color.White;

            }
            else if (sifre.Length < 6)
            {
                lblPower.BackColor = Color.Red;

            }
            else if (sifre.Length >= 6)
            {
                if (sifre.All(Char.IsDigit) || sifre.All(Char.IsLetter) || !sifre.Any(Char.IsLetterOrDigit))
                {
                    lblPower.BackColor = Color.Red;

                }
                else if (sifre.Any(Char.IsDigit) && sifre.Any(Char.IsLetter) && !sifre.All(Char.IsLetterOrDigit))
                {
                    lblPower.BackColor = Color.Green;

                }

                else
                {
                    lblPower.BackColor = Color.Blue;

                }
            }
        }
    }
}
