using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public class Fighter : IFighter
    {
        public string _name;
        public string _move { get; set; }
        public int _health = 100;

        public Fighter()
        {
        }
        public void AttackMove()
        {
            Opponent _opponent = new Opponent();
            while (_health > 0)
            {
                Console.WriteLine("\nMake a move");
                _move = Convert.ToString(Console.ReadLine());
                Random Random = new Random();
                Random Crit = new Random();
                int _crit = Crit.Next(5, 16);
                int _random = Random.Next(0, 10);

                if (_move == "jab" || _move == "uppercut" || _move == "right hook" || _move == "left hook")
                {
                    if (_crit == 15)
                    {
                        Console.WriteLine("You CRIT! for {0}!", _crit);
                        _opponent._health -= _crit;
                        Console.WriteLine("{0} has {1} left", _opponent._name, _health);
                    }
                    else
                    {
                        Console.WriteLine("You hit for {0}!", _random);
                        _opponent._health -= _random;
                        Console.WriteLine("{0} has {1} left", _opponent._name, _health);
                    }
                }
                else
                {
                    Console.WriteLine("\nYou have to make a move");
                }
                if (_health <= 0)
                {
                    Console.WriteLine("You won!");
                }
            }

            
        }
        

    }
}

        
    




