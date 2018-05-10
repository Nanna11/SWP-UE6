using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    class StateDownloaded : State
    {
        public StateDownloaded(string GameName) : base(GameName)
        {
        }

        public override IState Install()
        {
            Console.WriteLine(_GameName + "has been installed.");
            return new StateInstalled(_GameName);
        }

        public override IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded - you already downloaded it.");
            return this;
        }

        public override IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            return new StateLent(_GameName, this);
        }

        public override bool InstallAvailable
        {
            get
            {
                return true;
            }
        }

        public override bool LendAvailable
        {
            get
            {
                return true;
            }
        }

    }
}
