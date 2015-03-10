using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public class Opponent
    {
        public string _name;
        public int _health = 100;
        private string _move;

        public Opponent()
        {
        }

        public void AttackMove()
        {
            Fighter _fighter = new Fighter();
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
                        _fighter._health -= _crit;
                        Console.WriteLine("{0} has {1} left", _fighter._name, _health);
                    }
                    else
                    {
                        Console.WriteLine("You hit for {0}!", _random);
                        _fighter._health -= _random;
                        Console.WriteLine("{0} has {1}} left", _fighter._name, _health);
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
