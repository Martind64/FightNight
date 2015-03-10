using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public interface IFighter
    {
        string _move { get; set; }
        void AttackMove();
      

    }
}
