using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(rows_TextBox.Text);
            int columns = int.Parse(columns_TextBox.Text);
            GameWindow g = new GameWindow(rows, columns);

            g.Show();
        }
    }
}
