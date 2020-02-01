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
                card_stack.Push(new Card(rand));
            }
        }
        public Card dealCard()
        {
            if (card_stack.Count > 0) return card_stack.Pop();
            else return null;
        }
    }
}
