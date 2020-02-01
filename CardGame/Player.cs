using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        private string name_;
        public List<Card> hand_var = new List<Card>(); 
        public List<Card> hand
        {
            get { return hand_var; }
            set { hand_var = value; }
        }

        public Player(string name)
        {
            name_ = name;
        }

        public int total
        {
            get {
                int value = 0;
                foreach (var card in hand)
                {
                    value += card.Value;
                }
                return value;
            }
        }

        public List<Card> showHand()
        {
            return hand;
        }

    }
}
