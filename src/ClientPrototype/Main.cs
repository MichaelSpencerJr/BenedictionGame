using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benediction
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pbBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(sender is PictureBox pbClicked)) return;
            if (pbClicked != pbBoard) return;

            textBox1.Text = $"{e.X} / {e.Y} vs {splitContainer1.Panel1.Width} / {splitContainer1.Panel1.Height}";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pbBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
