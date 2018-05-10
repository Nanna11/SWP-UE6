using GameStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Commands
{
    public class Command : ICommand
    {
        protected Game _game;

        public Command(Game game)
        {
            _game = game;
        }

        public virtual void Execute() { }
    }
}
