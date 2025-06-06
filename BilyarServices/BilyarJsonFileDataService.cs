using BilyaranCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BilyaranServices
{
    public class BilyarJsonFileDataService : IBilyarDataService
    {
        private readonly string JsonFilePath = "BilyaranJson.json";
        private List<BTables> BilyarTables;
        public BilyarJsonFileDataService()
        {
            LoadBilyarData();
        }
        private void LoadBilyarData()
        {
            if (File.Exists(JsonFilePath))
            {
                string JsonData = File.ReadAllText(JsonFilePath);
                if (string.IsNullOrWhiteSpace(JsonData) || JsonData.Trim() == "[]")
                {
                    InitializeTables();
                }
                var loaded = JsonSerializer.Deserialize<List<BTables>>(JsonData,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                BilyarTables = loaded ?? new List<BTables>();
            }
            else
            {
                InitializeTables();
            }
        }
        private void InitializeTables()
        {
            BilyarTables = new List<BTables>();
            for (int i = 1; i <= 4; i++)
            {
                BilyarTables.Add(new BTables(i));
            }
            SaveToJsonFile();
        }
        private void SaveToJsonFile()
        {
            string JsonData = JsonSerializer.Serialize(BilyarTables, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonFilePath, JsonData);
        }
        public List<BTables> GetAllTables()
        {
            LoadBilyarData();
            return new List<BTables>(BilyarTables);
        }
        public BTables GetTables(int tableNumber)
        {
            LoadBilyarData();
            return BilyarTables.Find(t => t.TableNumber == tableNumber);
        }
        public void AddPlayerToTable(int tableNumber, string PlayerName)
        {
            LoadBilyarData();
            var PlayerTable = BilyarTables.Find(t => t.TableNumber == tableNumber);
            if (PlayerTable != null && PlayerTable.BilyarPlayers.Count < 2)
            {
                PlayerTable.BilyarPlayers.Add(new Player(PlayerName));
                SaveToJsonFile();
            }
        }
        public bool RemovePlayer(int tableNumber)
        {
            LoadBilyarData();
            var PlayerTable = BilyarTables.Find(t => t.TableNumber == tableNumber);
            if (PlayerTable != null && PlayerTable.BilyarPlayers.Count > 0)
            {
                PlayerTable.BilyarPlayers.Clear();
                SaveToJsonFile();
                return true;
            }
            return false;
        }
        public bool UpdatePayment(int tableNumber, string PlayerName, int payment)
        {
            LoadBilyarData();
            var PlayerTable = BilyarTables.Find(t => t.TableNumber == tableNumber);
            if (PlayerTable != null)
            {
                var PaymentPlayer = PlayerTable.BilyarPlayers.Find
                    (p => p.Name.Equals(PlayerName, StringComparison.OrdinalIgnoreCase));
                if (PaymentPlayer != null)
                {
                    PaymentPlayer.Payment += payment;
                    SaveToJsonFile();
                    return true;

                }
            }
            return false;
        }
    }
}
