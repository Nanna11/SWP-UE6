using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    class StateLent : State
    {
        IState before;
        public StateLent(string GameName, State Before) : base(GameName)
        {
            before = Before;
        }

        public override IState Buy()
        {
            Console.WriteLine(_GameName + "cannot be bought bought - you already own it");
            return this;
        }

        public override IState Download()
        {
            before = before.Download();
            return this;
        }

        public override IState Install()
        {
            before = before.Install();
            return this;
        }

        public override IState Lend(User lendTo)
        {
            //Console.WriteLine(_GameName + "cannot be lended - you already lent it to " + currentUser.Name);
            return this;
        }

        public override IState Retrieve()
        {
            Console.WriteLine(_GameName + "has been retrieved.");
            return before;
        }

        public override IState Start()
        {
            //Console.WriteLine(_GameName + "cannot be started - you lent it to " + currentUser.Name);
            return this;
        }

        public override IState Uninstall()
        {
            before = before.Uninstall();
            return this;
        }

        public override bool DownloadAvailable
        {
            get
            {
                return before.DownloadAvailable;
            }
        }

        public override bool InstallAvailable
        {
            get
            {
                return before.InstallAvailable;
            }
        }

        public override bool StartAvailable
        {
            get
            {
                return false;
            }
        }

        public override bool RetrieveAvailable
        {
            get
            {
                return true;
            }
        }

        public override bool UninstallAvailable
        {
            get
            {
                return before.UninstallAvailable;
            }
        }
    }
}
