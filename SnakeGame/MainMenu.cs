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
    public partial class MainMenu : Form
    {
        public static int difficulty_speed;
        public static bool game_borders = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            difficulty_speed = 16;
            //Link para o Jogo
            Game game = new Game();
            game.Show();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            difficulty_speed = 32;
            game_borders = true;
            //Link para o Jogo
            Game game = new Game();
            game.Show();
        }

        private void btn_very_hard_Click(object sender, EventArgs e)
        {
            difficulty_speed = 64;
            game_borders = true;
            //Link para o Jogo
            Game game = new Game();
            game.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Encerra a aplicacao
            this.Close();
        }


    }
}
