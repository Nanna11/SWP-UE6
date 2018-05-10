using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;

namespace GameStore.States
{
    abstract class State : IState
    {
        protected string _GameName;

        public State(string GameName)
        {
            _GameName = GameName;
        }

        virtual public bool BuyAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool DownloadAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool InstallAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool StartAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool LendAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool RetrieveAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public bool UninstallAvailable
        {
            get
            {
                return false;
            }
        }

        virtual public IState Buy()
        {
            Console.WriteLine(_GameName + "cannot be bought bought - you already own it");
            return this;
        }

        virtual public IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded until you bought or lended it.");
            return this;
        }

        virtual public IState Install()
        {
            Console.WriteLine(_GameName + "cannot be installed until you downloaded it.");
            return this;
        }

        virtual public IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "cannot be lended until you buy it.");
            return this;
        }

        virtual public IState Retrieve()
        {
            Console.WriteLine(_GameName + "cannot be retrieved - you did not lend it to someone.");
            return this;
        }

        virtual public IState Start()
        {
            Console.WriteLine(_GameName + "cannot be started until you installed it.");
            return this;
        }

        virtual public IState Uninstall()
        {
            Console.WriteLine(_GameName + "cannot be uninstalled - you need to install it first.");
            return this;
        }

        
    }
}
