using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGame
{

    abstract class Game
    {
        protected int CARDS_IN_HAND = 5;
        protected List<Player> playerList = new List<Player>();
        protected Deck deck_;
        protected Random rand = new Random();

        public abstract void run();

        protected Game(int deck_size)
        {
            deck_ = new Deck(deck_size, rand);
        }

        protected Game(Game copy_me)
        {
            this.deck_ = copy_me.deck_;
            this.playerList = copy_me.playerList;
            this.rand = copy_me.rand;
        }

    }

    class preGame : Game
    {
        public preGame(Game copy_me)
            : base(copy_me)
        {

        }

        public preGame(int deck_size)
            : base(deck_size)
        { }

        public override void run()
        {
            Console.WriteLine("Hello there! Welcome to this fun game!");
            Console.Write("How many players will be joining: ");
            var amount = Console.ReadLine();
            for (int i = 0; i < int.Parse(amount); i++)
            {
                playerList.Add(new Player("Player " + i));
                Console.WriteLine("Added player " + i);
            }
            Console.WriteLine("Ready to start?");
            while (Console.ReadLine() != "y") ;

        }
    }
    class duringGame : Game
    {
        public duringGame(Game copy_me)
            : base(copy_me)
        {

        }

        public override void run()
        {
            Console.WriteLine("Game is now started!");
            Console.Write("Dealing cards!");

            foreach (var player_ in playerList)
            {
                for (int i = 0; i < CARDS_IN_HAND; i++)
                {
                    player_.hand.Add(deck_.dealCard());
                }
            }
            Console.WriteLine("Cards have now been dealt!");
            Console.WriteLine("Ready to see who is the winner?");
            while (Console.ReadLine() != "y") ;

        }

    }

    class postGame : Game
    {
        public postGame(Game copy_me)
            : base(copy_me)
        {

        }

        public override void run()
        {
            Console.WriteLine("Game is now done!");
            Console.WriteLine("The scores are as follows:");

            playerList.Sort((x, y) => x.total.CompareTo(y.total));
            playerList = playerList.OrderByDescending(x => x.total).ToList();

            foreach (var player_ in playerList)
            {
                Console.WriteLine(player_.name + "\t:\t" + player_.total);
            }

            Console.WriteLine("Thank you! Bye bye!");
            while (Console.ReadLine() != "y") ;

        }

    }
}
