using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weightlifting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)  {
                    Environment.Exit(0);
            }
                else return;
        }
    }
}
