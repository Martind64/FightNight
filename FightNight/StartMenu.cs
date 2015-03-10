using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public class StartMenu
    {
        Fighter fighter = new Fighter();
        Opponent opponent = new Opponent();
        public void StartGame()
        {

            Console.WriteLine("WEEEEEELCOME to the AREEEEENA! WHAT... IS.. YOUR... NAAAAAAAME?");
            fighter._name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("GREAT {0}, now what is the name of your opponent?", fighter._name);
            opponent._name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0} AND {1} Are to fight an epic fight!... LET THE BATTLE COMMENCE!", fighter._name, opponent._name);

            fighter.AttackMove();
            



        }


    }
}
