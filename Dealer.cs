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
        private List<string> hand;
        private string i;

        public List<string> Generate (string insert) // El metodo generate tiene la misma naturaleza que 
                                                     //el metodo "Addcard" por lo cual decidimos unirlo en un solo metodo.

        {
            List<string> deck = new List<string>();

            deck.Add("corazón");
            deck.Add("trebol");
            deck.Add("Diamante");
            deck.Add("Picas");
            deck.Add(insert);

            hand = deck;
            return hand;
        }

        public List<string> Randomize()
        {
            List<string> deck = new List<string>();

            deck.Add("corazón");
            deck.Add("trebol");
            deck.Add("Diamante");
            deck.Add("Picas");

            deck.Reverse();

            hand = deck;
            return hand;
        }

        public List<string> Deal(string i)
        {
            List<string> deck = new List<string>();

            deck.Add("corazón");
            deck.Add("trebol");
            deck.Add("Diamante");
            deck.Add("Picas");

            deck.Remove(i);

            hand = deck;
            return hand;
        }

        public List<string> Init ()
        {
            return Deal(I);

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

        public string I
        {
            get { return i; }
            set { i = value; }
        }
    }
}
