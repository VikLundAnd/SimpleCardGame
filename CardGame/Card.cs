using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{

    class Card
    {
        private int mul;
        private int num;
        private string type;

        List<(int,string)> types_of_card = new List<(int, string)>
        {
            ( 1, "red" ),
            ( 2, "blue" ),
            ( 3, "green" ),
            ( 4, "yellow" ),
            ( 5, "gold" )
        };

        public Card(Random rand)
        {
            num = rand.Next(1, 8);
            int idx = rand.Next(1, types_of_card.Count);
            mul = types_of_card[idx].Item1;
            type = types_of_card[idx].Item2;

        }

        public int Value
        {
            get { return num * mul; }
        }
        public string Type
        {
            get { return type; }
        }
    }


}

