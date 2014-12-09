using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightNight
{
    public class Opponent : IFighter
    {
        public string _move { get; set; }

        public Opponent(string move)
        {
            _move = move;
        }
        public string Move
        {
            get { return _move; }
            set { _move = value; }
        }


        public void UpperCut()
        {
            throw new NotImplementedException();
        }

        public void Jab()
        {
            throw new NotImplementedException();
        }

        public void SpecialMove()
        {
            throw new NotImplementedException();
        }

        public void RightHook()
        {
            throw new NotImplementedException();
        }

        public void LeftHook()
        {
            throw new NotImplementedException();
        }

        public void SuckerPunch()
        {
            throw new NotImplementedException();
        }

        public void RightCross()
        {
            throw new NotImplementedException();
        }

        public void LeftCross()
        {
            throw new NotImplementedException();
        }
    }
}
