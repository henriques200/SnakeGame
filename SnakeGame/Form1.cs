using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //Declarar um novo jogador
        private List<Circle>Snake = new List<Circle>();

        //Declarar um objeto para comida
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            //Definir as configuracoes iniciais.
            new Config();

            //Definir a velocidade do jogo e iniciar o temporizador
            gameTimer.Interval = 1000 / Config.Speed;
            gameTimer.Tick += update_screen();
            gameTimer.Start();

            //Iniciar novo jogo
            start_game();
        }

        private void start_game()
        {
            label_game_over.Visible = false;

            //Volta a definir as configuracoes iniciais.
            new Config();

            //Limpar qualquer progresso feito anterior.
            Snake.Clear();

            //Cria um novo jogador e definir as coordenadas iniciais.
            Circle head = new Circle();
            head.x = 10;
            head.y = 5;
            Snake.Add(head);

            label_score.Text = Config.Score.ToString();

            generate_food();
        }

        private void generate_food()
        {
            /*
             Esta funcao vai permitir gerar comida de forma aleatoria no ecra do jogo.
             */

            int max_x_pos = pictureBox1.Size.Width / Config.Width;
            int max_y_pos = pictureBox1.Size.Height / Config.Height;

            //Cria a comida num local aleatorio
            Random random = new Random();
            food = new Circle();
            food.x = random.Next(0, max_x_pos);
            food.y = random.Next(0, max_y_pos);
        }

        private void update_screen(object sender, EventArgs e)
        {
            //Verifica se o jogo chegou ao fim.
            if(Config.GameOver == true)
            {
                if (Input.keypressed(Keys.Enter)) start_game();
            }
            else
            {
                if (Input.keypressed(Keys.Right) && Config.direction != Direction.Left) Config.direction = Direction.Right;
                else if (Input.keypressed(Keys.Left) && Config.direction != Direction.Right) Config.direction = Direction.Left;
                else if (Input.keypressed(Keys.Up) && Config.direction != Direction.Down) Config.direction = Direction.Up;
                else if (Input.keypressed(Keys.Down) && Config.direction != Direction.Up) Config.direction = Direction.Down;

                move_player();
            }

            //Certificar que os dados sao eliminados para proceder a sua atualizacao.
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Config.GameOver != false)
            {
                //Definir a cor da cobra
                Brush snake_color;

                //Desenha os elementos do jogo.
                for(int i=0; i<Snake.Count; i++)
                {
                    if(i == 0) snake_color = Brushes.Black; //Desenha Cabeca
                    else snake_color = Brushes.Green; //Desenha resto do corpo

                    //Desenha a cobra.
                    canvas.FillEllipse(snake_color, new Rectangle(Snake[i].x * Config.Width,
                                                                  Snake[i].y * Config.Height,
                                                                  Config.Width, Config.Height));
                    //Desenha a comida.
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.x * Config.Width,
                                                                  food.y * Config.Height,
                                                                  Config.Width, Config.Height));
                }
            }
            else
            {
                string game_over_msg = "Fim do Jogo!\nA tua pontuação final é:" + Config.Score + "\nPrime ENTER para tentar de novo.";
                label_game_over.Text = game_over_msg;
                label_game_over.Visible = true;
            }
        }

        private void move_player()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = Snake.Count-1; i >= Snake.Count; i--)
            {
                //Move a cabeca
                if(i == 0)
                {
                    switch (Config.direction)
                    {
                        case Direction.Right:
                            Snake[i].x++;
                            break;
                        case Direction.Left:
                            Snake[i].x--;
                            break;
                        case Direction.Up:
                            Snake[i].y--;
                            break;
                        case Direction.Down:
                            Snake[i].y++;
                            break;
                    }
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }
    }
}
