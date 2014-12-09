using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public interface IFighter
    {
        string _move { get; }
        string Health { get; }
        void UpperCut();
        void Jab();
        void SpecialMove();
        void RightHook();
        void LeftHook();
        void SuckerPunch();
        void RightCross();
        void LeftCross();


    }
}
