using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Bibliotecas para JSON
using System.IO;
using Newtonsoft.Json;
//Biblioteca InputBoxes
using Microsoft.VisualBasic;

namespace SnakeGame
{
    public partial class MainMenu : Form
    {
        public static int difficulty_speed;
        public static bool game_borders;
        public static string username;
        public static string score_data = "leader.json";
        public int podio;

        public MainMenu()
        {
            InitializeComponent();

            string json_string = System.IO.File.ReadAllText(score_data);
            List<LeaderBoard> leaders_list = JsonConvert.DeserializeObject<List<LeaderBoard>>(json_string).OrderByDescending(x => x.FinalScore).ToList();

            podio = 1;
            leaders_board.Text = ""; //Limpa o texto que esta por omissao
            for (int i = 0; i < 5; i++)
            {
                leaders_board.Text += podio++.ToString() + "º - " + leaders_list[i].Name + " - " + leaders_list[i].FinalScore.ToString() + " Pontos\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Introduz o username
            username = Interaction.InputBox("Introduz o teu nome:", "Introduz o nome", "", 100, 200);

            //Verifica se o username foi introduzido
            if (string.IsNullOrEmpty(username)) MessageBox.Show("Introduz um nome válido!");
            else
            {
                difficulty_speed = 16;
                game_borders = false;
                //Link para o Jogo (modo normal)
                Game game = new Game();
                game.Show();
            }

        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            //Introduz o username
            username = Interaction.InputBox("Introduz o teu nome:", "Introduz o nome", "", 100, 200);

            //Verifica se o username foi introduzido
            if (string.IsNullOrEmpty(username)) MessageBox.Show("Introduz um nome válido!");
            else
            {
                difficulty_speed = 32;
                game_borders = true;
                //Link para o Jogo (modo dificil)
                Game game = new Game();
                game.Show();
            }
        }

        private void btn_very_hard_Click(object sender, EventArgs e)
        {
            //Introduz o username
            username = Interaction.InputBox("Introduz o teu nome:", "Introduz o nome", "", 100, 200);

            //Verifica se o username foi introduzido
            if (string.IsNullOrEmpty(username)) MessageBox.Show("Introduz um nome válido!");
            else
            {
                difficulty_speed = 64;
                game_borders = true;
                //Link para o Jogo (modo muito dificil)
                Game game = new Game();
                game.Show();
            }

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

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //Atualiza o podio
            string json_string = System.IO.File.ReadAllText(score_data);
            List<LeaderBoard> leaders_list = JsonConvert.DeserializeObject<List<LeaderBoard>>(json_string).OrderByDescending(x => x.FinalScore).ToList();

            podio = 1;
            leaders_board.Text = ""; //Limpa o texto que esta por omissao
            for (int i = 0; i < 5; i++)
            {
                leaders_board.Text += podio++.ToString() + "º - " + leaders_list[i].Name + " - " + leaders_list[i].FinalScore.ToString() + " Pontos\n";
            }
        }
    }
}
