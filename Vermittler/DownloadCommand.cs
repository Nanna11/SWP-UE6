using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Commands
{
    class DownloadCommand : Command
    {
        public DownloadCommand(Game game) : base(game) { }

        public override void Execute()
        {
            _game.Download();
        }
    }
}
