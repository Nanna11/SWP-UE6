using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    class StateNotOwned : State
    {
        public StateNotOwned(string GameName) : base(GameName)
        {
        }

        public override IState Buy()
        {
            Console.WriteLine(_GameName + "has been bought.");
            return new StateOwned(_GameName);
        }
    }
}
