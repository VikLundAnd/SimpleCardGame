using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{

    class Card
    {
        protected int mul;
        private int num;
        protected string type;

        public Card(Random rand)
        {
            num = rand.Next(1, 8);
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

    class red_card : Card
    {
        public red_card(Random rand) : base(rand)
        {
            mul = 1;
            type = "red";
        }
    }
    class blue_card : Card
    {
        public blue_card(Random rand) : base(rand)
        {
            mul = 2;
            type = "blue";

        }
    }
    class green_card : Card
    {
        public green_card(Random rand) : base(rand)
        {
            mul = 3;
            type = "green";

        }
    }
    class yellow_card : Card
    {
        public yellow_card(Random rand) : base(rand)
        {
            mul = 4;
            type = "yellow";

        }
    }

}

