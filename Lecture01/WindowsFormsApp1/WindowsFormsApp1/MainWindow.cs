using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            pokemonNameLabel.Text = string.Format("寶可夢的名子:{0}", "閃電鳥");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
