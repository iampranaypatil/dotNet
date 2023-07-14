using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoApp
{
    public class Team
    {

        private List<Player> _players = new List<Player>();
        public Team()
        {
            _players.Add(new Player { Name = "Sachin", Score = 50000 });
            _players.Add(new Player { Name = "Sourav", Score = 50000 });
            _players.Add(new Player { Name = "Virat", Score = 50000 });
            _players.Add(new Player { Name = "Rishabh", Score = 50000 });
        }

        public Player this[int index]
        {
            get { return this._players[index]; }
            set { this._players[index] = value; }
        }
    }
}
