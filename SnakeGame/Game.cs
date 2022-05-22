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
    public partial class Game : Form
    {
        //Declarar um novo jogador
        private List<Circle> Snake = new List<Circle>();

        //Declarar um objeto para comida
        private Circle food = new Circle();

        public Game()
        {
            InitializeComponent();
            
            //Definir as configuracoes iniciais.
            new Config();

            //Definir a velocidade do jogo e iniciar o temporizador
            Config.Speed = MainMenu.difficulty_speed;
            gameTimer.Interval = 1000 / Config.Speed;
            gameTimer.Tick += update_screen;
            gameTimer.Start();

            //Iniciar novo jogo
            start_game();
        }

        private void start_game()
        {
            label_game_over.Visible = false;
            pause_label.Visible = false;

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
            if(Config.GameOver)
            {
                if (Input.keypressed(Keys.Enter)) start_game();
                else if(Input.keypressed(Keys.Escape)) this.Close();
            }
            else
            {
                if (Input.keypressed(Keys.Right) && Config.direction != Direction.Left)
                {
                    Config.direction = Direction.Right;
                    pause_label.Visible = false;
                }
                else if (Input.keypressed(Keys.Left) && Config.direction != Direction.Right)
                {
                    Config.direction = Direction.Left;
                    pause_label.Visible = false;
                }
                else if (Input.keypressed(Keys.Up) && Config.direction != Direction.Down)
                {
                    Config.direction = Direction.Up;
                    pause_label.Visible = false;
                }
                else if (Input.keypressed(Keys.Down) && Config.direction != Direction.Up)
                {
                    Config.direction = Direction.Down;
                    pause_label.Visible = false;
                }
                else if (Input.keypressed(Keys.Space))
                {
                    Config.direction = Direction.Pause;
                    pause_label.Visible = true;
                }
                
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
            if (!Config.GameOver)
            {
                //Desenha os elementos do jogo.
                for (int i=0; i<Snake.Count; i++)
                {
                    //Definir a cor da cobra
                    Brush snake_color;

                    if (i == 0) snake_color = Brushes.Black; //Desenha Cabeca
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
                string game_over_msg = "Fim do Jogo!\nA tua pontuação final é: " + Config.Score + "\nPrima ENTER para tentar de novo ou ESC para sair.";
                label_game_over.Text = game_over_msg;
                label_game_over.Visible = true;
            }
        }

        private void move_player()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move a cabeca
                if (i == 0)
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
                    int maxXpos = pictureBox1.Size.Width / Config.Width;
                    int maxYpos = pictureBox1.Size.Height / Config.Height;

                    
                    if (MainMenu.game_borders)
                    {
                        //Deteta colisao com as fronteiras do jogo (fronteiras ativadas).
                        if (Snake[i].x < 0 || Snake[i].y < 0 || Snake[i].x >= maxXpos || Snake[i].y >= maxYpos) die();
                    }
                    else
                    {
                        // Passa para o outro lado do jogo (fronteiras desativadas).
                        if (Snake[i].x < 0) Snake[i].x = maxXpos;
                        if (Snake[i].x > maxXpos) Snake[i].x = 0;
                        if (Snake[i].y < 0) Snake[i].y = maxYpos;
                        if (Snake[i].y > maxYpos) Snake[i].y = 0;
                    }

                    //Deteta colisao com o corpo
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y) die();
                    }

                    //Deteta colisao com comida
                    if (Snake[0].x == food.x && Snake[0].y == food.y) eat();
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void die()
        {
            pause_label.Visible = false;
            Config.GameOver = true;
        }

        private void eat()
        {
            //Aumenta o corpo.
            Circle circle = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            Snake.Add(circle);

            //Aumenta a pontuacao
            Config.Score += Config.Points;
            label_score.Text = Config.Score.ToString();

            generate_food();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.changestate(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.changestate(e.KeyCode, false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
