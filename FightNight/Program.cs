using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter = new Fighter();
            StartMenu start = new StartMenu();

            start.StartGame();
            
        }
    }
}
