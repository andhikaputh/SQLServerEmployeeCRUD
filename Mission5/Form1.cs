using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void lihatSemuaPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
        }
    }
}
