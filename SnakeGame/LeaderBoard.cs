using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class LeaderBoard
    {
        public int FinalScore { get; set; }
        public string Name { get; set; }

        //Construtor
        public LeaderBoard(int score, string username)
        {
            FinalScore = score;
            Name = username;
        }
    }
}
