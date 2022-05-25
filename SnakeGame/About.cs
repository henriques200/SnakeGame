using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class About : Form
    {
        ToolTip comentario = new ToolTip();

        public About()
        {
            InitializeComponent();
        }

        private void mascot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ssssssssssss!", "ssssssssssss!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void mascot_MouseHover(object sender, EventArgs e)
        {
            //Mostrar comentario quando passa o rato pela imagem
            comentario.Show("?????", mascot);
        }
    }
}
