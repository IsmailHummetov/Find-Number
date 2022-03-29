using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace kontrol_yapilar_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cehd, eded, texmin;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTexmin.Enabled = false;
            lblText.Text = "Fikrinizde 1-100 arasi \n" +
                "     bir eded tutun";
            lblText.Size = new Size(200, 30);
        }

        private void btnTexmin_Click(object sender, EventArgs e)
        {
            texmin = Convert.ToInt32(Interaction.InputBox("Ededi daxil edin"));
            if (texmin < eded)
            {
                lblCavab.Text = "Daha boyuk!\n" + cehd + " cehdiniz qaldi.";
            }
            if (texmin > eded)
            {
                lblCavab.Text = "Daha kicik!\n" + cehd + " cehdiniz qaldi.";
            }
            if (texmin == eded)
            {
                lblCavab.Text = "Tebrikler!!! Texmin olunan eded " + eded + " idi.";
                btnTexmin.Enabled = false;
                cehd ++;
            }
            if (cehd > 0)
                cehd = cehd - 1;
            else
            {
                btnTexmin.Enabled = false;
                lblCavab.Text = "Tapa bilmediniz.\nTutulan eded " + eded + " idi.";
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            cehd = 4;
            btnTexmin.Enabled = true;
            eded = randomeded();
            lblCavab.Text = "";
        }

        private void lblCavab_Click(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        public static int randomeded()
        {
            Random rand = new Random();
            return rand.Next(1, 100);
        }
    }
}
