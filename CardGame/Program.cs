﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            preGame pG = new preGame(10);
            pG.run();

            duringGame dG = new duringGame(pG);
            dG.run();


        }
    }
}
