using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        protected int cards_in_hand = 5; 

        private string name_;
        public List<Card> hand_var = new List<Card>(); 
        public List<Card> hand
        {
            get { 
                while (hand_var.Count > cards_in_hand)
                {
                    hand_var.RemoveAt(hand_var.Count - 1);
                }
                
                return hand_var; }
            set { hand_var = value; }
        }
        public string name
        {
            get { return name_; }
        }

        public Player(string name)
        {
            name_ = name;
        }

        public int total
        {
            get {
                int value = 0;
                foreach (var card in hand_var)
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

    class weakPlayer : Player
    {
        weakPlayer(string name) 
            :base(name)
        {
            cards_in_hand = 3;
        }
    }
}
