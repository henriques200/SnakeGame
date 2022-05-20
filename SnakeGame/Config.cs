﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    // Enumerar todas as direcoes possiveis no jogo.
    public enum Direction { Up, Down, Left, Right}

    class Config
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        // Construtor com as configuracoes iniciais.
        public Config()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
