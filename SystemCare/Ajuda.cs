using System;
using System.Diagnostics;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Ajuda : MetroForm
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cactusdevs.com.br");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cactusdevs.com.br/manual");
        }
    }
}