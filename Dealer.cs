using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Media.Animation;

namespace SimpleGame
{
    class Dealer
    {
        private string insert;
        private List <string> hand;

        public void Generate(string insert) 
        {
            this.insert = insert;

            List<string> deck = new List<string>();

            deck.Add("corazón");
            deck.Add("trebol");
            deck.Add("Diamante");
            deck.Add("Picas");
            deck.Add(insert);

            hand = deck;
        }

        public void Random()
        {
            List<string> deck = new List<string>();

            deck.Add("corazón");
            deck.Add("trebol");
            deck.Add("Diamante");
            deck.Add("Picas");

            deck.Reverse();

            hand = deck;
        }

        public string Insert
        {
            get { return insert; }
            set { insert = value; }
        }

        public List<string> Hand
        {
            get { return hand; }
            set { hand = value; }
        }
    }
}
