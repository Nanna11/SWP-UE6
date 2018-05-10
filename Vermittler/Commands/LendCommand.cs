using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Commands
{
    class LendCommand : Command
    {
        public LendCommand(Game game) : base(game) { }

        public override void Execute()
        {
            Console.WriteLine("Which user is allowed to lend the game?: ");
            string lendTo = Console.ReadLine();
            _game.Lend(new User(lendTo));
        }
    }
}
