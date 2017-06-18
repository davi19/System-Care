using System;
using System.Data;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SystemCare
{
    public partial class Relatorios : MetroForm
    {
        public Relatorios(byte[] Arquivo)
        {
            InitializeComponent();

            File.WriteAllBytes("algo.pdf", Arquivo);
            string s = System.Text.Encoding.UTF8.GetString(Arquivo);
            axAcroPDF1.LoadFile("algo.pdf");
        }

       
    }
}