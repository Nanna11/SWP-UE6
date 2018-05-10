using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interfaces;
using GameStore.States;
using System.ComponentModel;

namespace GameStore
{
    public class Game : INotifyPropertyChanged
    {
        string name;
        IState state;

        public event PropertyChangedEventHandler PropertyChanged;

        public Game(string GameName)
        {
            State = new StateNotOwned(GameName);
            name = GameName;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        IState State {
            get
            {
                return state;
            }
            set
            {
                state = value;
                StateChanged();
            }
        }

        public void Buy()
        {
            State = State.Buy();
        }

        public void Download()
        {
            State = State.Download();
        }

        public void Install()
        {
            State = State.Install();
        }

        public void Start()
        {
            State = State.Start();
        }

        public void Lend(User lendTo)
        {
            State = State.Lend(lendTo);
        }

        public void Retrieve()
        {
            State = State.Retrieve();
        }

        public void Uninstall()
        {
            State = State.Uninstall();
        }

        public bool buyAvailable
        {
            get
            {
                return State.BuyAvailable;
            }
        }

        public bool downloadAvailable
        {
            get
            {
                return State.DownloadAvailable;
            }
        }

        public bool installAvailable
        {
            get
            {
                return State.InstallAvailable;
            }
        }

        public bool startAvailable
        {
            get
            {
                return State.StartAvailable;
            }
        }

        public bool lendAvailable
        {
            get
            {
                return State.LendAvailable;
            }
        }

        public bool retrieveAvailable
        {
            get
            {
                return State.RetrieveAvailable;
            }
        }

        public bool uninstallAvailable
        {
            get
            {
                return State.UninstallAvailable;
            }
        }


        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void StateChanged()
        {
            OnPropertyChanged("buyAvailable");
            OnPropertyChanged("downloadAvailable");
            OnPropertyChanged("startAvailable");
            OnPropertyChanged("lendAvailable");
            OnPropertyChanged("retrieveAvailable");
            OnPropertyChanged("uninstallAvailable");
            OnPropertyChanged("installAvailable");
        }
    }
}
