using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Media;

namespace SimpleGame
{
    class Card
    {
        private string symbol;
        private string suit;
        private string color;
        private int score;
        private bool decide;

        public Card(string symbol, string suit,bool decide)
        {
            this.symbol = symbol;
            this.suit = suit;

            Random points = new Random();
            int score;
            score = points.Next(0, 11);

            Console.WriteLine("True or false");

            if (decide == true)
            {
                color = "red";
            }
            else
            {
                color = "black";
            }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public bool Decide
        {
            get { return decide; }
            set { decide = value; }
        }

        public string Showinformation()
        {
            return "Ur symbol is" + symbol + "\n" + "Ur suit is" + suit + "\n" + "ur color is" + color + "\n" + "And ur score is" + score;
        }
    }
}
