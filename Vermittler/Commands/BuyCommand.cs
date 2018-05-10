using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Commands
{
    public class BuyCommand : Command
    {
        public BuyCommand(Game game) : base(game) { }

        public override void Execute()
        {
            _game.Buy();
        }
    }
}
