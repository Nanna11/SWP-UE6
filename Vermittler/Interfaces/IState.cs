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
    }
}
