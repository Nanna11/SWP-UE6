using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    class StateOwned : State
    {
        public StateOwned(string GameName) : base(GameName)
        {
        }

        public override IState Download()
        {
            Console.WriteLine(_GameName + "has been downloaded.");
            return new StateDownloaded(_GameName);
        }

        public override IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            return new StateLent(_GameName, this);
        }

        public override bool DownloadAvailable
        {
            get
            {
                return true;
            }
        }

        public override bool  LendAvailable
        {
            get
            {
                return true;
            }
        }
    }
}
