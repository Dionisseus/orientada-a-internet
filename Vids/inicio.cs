using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vids
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            this.TransparencyKey = System.Drawing.ColorTranslator.FromHtml("#FFFF00");
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void getnickname_Click_1(object sender, EventArgs e)
        {
            getnickname.Text = "";
            getnickname.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_entrar_Click(object sender, EventArgs e)
        {
            principal nuevo = new principal(getnickname.Text);
            nuevo.Show();
            this.Visible = false;
        }
    }
}
