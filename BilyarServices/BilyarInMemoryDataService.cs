using BilyaranCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilyaranServices
{
    public class BilyarInMemoryDataService : IBilyarDataService
    {
        private List<BTables> BilyarTables;
        public BilyarInMemoryDataService()
        {
            BilyarTables = new List<BTables>();
            for (int i = 1; i <= 4; i++)
            {
                BilyarTables.Add(new BTables(i));
            }
        }
        public List<BTables> GetAllTables()
        {
            return BilyarTables;
        }
        public BTables GetTables(int tableNumber)
        {
            return BilyarTables.FirstOrDefault(t => t.TableNumber == tableNumber);
        }
        public void AddPlayerToTable (int tableNumber, string PlayerName)
        {
            var PlayerTable = GetTables(tableNumber);
            if (PlayerTable != null && PlayerTable.BilyarPlayers.Count < 2)
            {
                Player newPlayer = new Player(PlayerName);
                PlayerTable.BilyarPlayers.Add(newPlayer);
            }
        }
        public bool RemovePlayer(int tableNumber)
        {
            var PlayerTable = GetTables(tableNumber);
            if (PlayerTable != null && PlayerTable.BilyarPlayers.Count > 0)
            {
                PlayerTable.BilyarPlayers.Clear();
            }
            return false;
        }
        public bool UpdatePayment(int tableNumber, string PlayerName, int payment)
        {
            var PlayerTable = GetTables(tableNumber);
            if (PlayerTable != null)
            {
                var PaymentPlayer = PlayerTable.BilyarPlayers.FirstOrDefault(p => p.Name.Equals(PlayerName, StringComparison.OrdinalIgnoreCase));
                if (PaymentPlayer != null)
                {
                    PaymentPlayer.Payment += payment;
                    return true;
                }
            }
            return false;
        }
    }
}
