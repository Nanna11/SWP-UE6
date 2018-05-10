using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Interfaces
{
    public interface IState
    {
        IState Buy();
        IState Download();
        IState Install();
        IState Start();
        IState Uninstall();
        IState Lend(User lendTo);
        IState Retrieve();
        bool BuyAvailable { get; }
        bool DownloadAvailable { get; }
        bool InstallAvailable { get; }
        bool LendAvailable { get; }
        bool StartAvailable { get; }
        bool RetrieveAvailable { get; }
        bool UninstallAvailable { get; }
    }
}
