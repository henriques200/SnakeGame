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
        public static bool game_borders;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            difficulty_speed = 16;
            game_borders = false;
            //Link para o Jogo (modo normal)
            Game game = new Game();
            game.Show();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            difficulty_speed = 32;
            game_borders = true;
            //Link para o Jogo (modo dificil)
            Game game = new Game();
            game.Show();
        }

        private void btn_very_hard_Click(object sender, EventArgs e)
        {
            difficulty_speed = 64;
            game_borders = true;
            //Link para o Jogo (modo muito dificil)
            Game game = new Game();
            game.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Link para os creditos do jogo.
            About about = new About();
            about.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Encerra o jogo.
            this.Close();
        }
    }
}
