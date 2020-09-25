using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGame
{
    class Player
    {
        private List<string> hand;
        private string morecard;

        public List<string> Addcard(string morecard)
        {
            List<string> hand = new List<string>();
            hand.Add(morecard);
            return hand;

        }

        public List<string> Init (string morecard)
        {
            List<string> hand = new List<string>();
            hand.Add(morecard);
            return hand;
        }

        public List<string> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public string Morecard
        {
            get { return morecard; }
            set { morecard = value; }
        }
    }
}
