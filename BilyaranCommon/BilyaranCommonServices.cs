using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilyaranCommon
{
    public class Player
    {
        public string Name { get; set; }
        public int Payment { get; set; }

        public Player() { }
        public Player(string PlayerName)
        {
            Name = PlayerName;
            Payment = 0;
        }
    }
    public class BTables
    {
        public int TableNumber { get; set; }
        public List<Player> BilyarPlayers { get; set; } = new List<Player>();

        public BTables() { }
        public bool IsOccupied
        {
            get { return BilyarPlayers != null && BilyarPlayers.Count > 0; }
        }
        public BTables(int BilyarNumber)
        {
            TableNumber = BilyarNumber;
            BilyarPlayers = new List<Player>();
        }
    }

}

