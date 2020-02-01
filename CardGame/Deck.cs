using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    interface IDeck
    {
        Card dealCard();
    }
    class Deck : IDeck
    {
        Stack<Card> card_stack = new Stack<Card>();
        public Deck(int size, Random rand)
        {
            for (int i = 0; i < size; i++)
            {
                var temp_random = rand.Next(0, 3);
                switch (temp_random)
                {
                    case 0:
                        var card_red = new red_card(rand);
                        card_stack.Push(card_red);
                        break;
                    case 1:
                        var card_blue = new blue_card(rand);
                        card_stack.Push(card_blue);
                        break;
                    case 2:
                        var card_green = new green_card(rand);
                        card_stack.Push(card_green);
                        break;
                    case 3:
                        var card_yellow = new yellow_card(rand);
                        card_stack.Push(card_yellow);
                        break;
                }
            }
        }
        public Card dealCard()
        {
            if (card_stack.Count > 0) return card_stack.Pop();
            else return null;
        }
    }
}
