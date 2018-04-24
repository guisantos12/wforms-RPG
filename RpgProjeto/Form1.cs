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

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"G:\RPG\Playlist RPG\BATALHA\Most Wondrous Battle Music And The Sky Shall Unfold by Johannes Bornlöf.mp3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"G:\RPG\Playlist RPG\TAVERNAS E VILAREJOS\RPG Playlist - TavernFestival Music.mp3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            string[] l = new string[3];
            l[0] = @"G:\RPG\Playlist RPG\TAVERNAS E VILAREJOS\Best Tavern Epic Music Bard Songs Compilation Mix - Medieval and Fantasy Inn Epic Music 2017.mp3";
            l[1] = @"G:\RPG\Playlist RPG\TAVERNAS E VILAREJOS\Vilarejo Medieval         Música Medieval.mp3";
            l[2] = @"G:\RPG\Playlist RPG\TAVERNAS E VILAREJOS\Medieval Music - Cobblestone Village.mp3";
            int a = r.Next(0, 3);
            System.Diagnostics.Process.Start(l[a]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
