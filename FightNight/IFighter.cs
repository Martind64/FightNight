using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
     public interface IFighter
     {
         string UpperCut { get; }

         string Jab { get; }
         string SpecialMove { get; }
         string RightHook { get; }
         string LeftHook { get; }
         string SuckerPunch { get; }

         


     }
}
