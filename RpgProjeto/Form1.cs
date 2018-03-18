using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = new string[]
            {
                "Batalha",
                "vilarejo",
                "viajando"
            };
            comboBox1.Items.AddRange(valores);
        }
    }
}
