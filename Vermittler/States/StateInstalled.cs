using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    class StateInstalled : State
    {
        public StateInstalled(string GameName) : base(GameName)
        {
        }

        public override IState Start()
        {
            Console.WriteLine("You played " + _GameName + ". That was fun.");
            return this;
        }

        public override IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded - you already downloaded it.");
            return this;
        }

        public override IState Uninstall()
        {
            Console.WriteLine(_GameName + "has been unistalled.");
            return new StateDownloaded(_GameName);
        }


        public override IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            return new StateLent(_GameName, lendTo, this);
        }
    }
}
