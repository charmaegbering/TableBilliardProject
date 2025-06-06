using BilyaranCommon;
using BilyaranServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BilyaranServices
{
    public class BilyarTextFileDataService : IBilyarDataService
    {
        private string TextFilePath = "BilyaranTextFile.txt";
        private List<BTables> BilyarTables;
        public BilyarTextFileDataService()
        {
            LoadBilyarData();
        }
        private void LoadBilyarData()
        {
            BilyarTables = new List<BTables>();
            if (File.Exists(TextFilePath))
            {
                for (int i = 1; i <= 4; i++)
                {
                    BilyarTables.Add(new BTables(i));
                }
                return;
            }
            string[] TextLine = File.ReadAllLines(TextFilePath);
            BTables CurrentTable = null;
            foreach (string line in TextLine)
            {
                if (line.StartsWith("Table"))
                {
                    int tableNumber = int.Parse(line.Split(' ')[1]);
                    CurrentTable = new BTables(tableNumber);
                    BilyarTables.Add(CurrentTable);
                }
                else if (!string.IsNullOrWhiteSpace(line) && CurrentTable != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)

                    {
                        string playerName = parts[0].Trim();
                        int payment = int.Parse(parts[1].Trim(),
                            CultureInfo.InvariantCulture);
                        CurrentTable.BilyarPlayers.Add(new Player
                            (playerName)
                        {
                            Payment = payment
                        });
                    }
                }
            }
        }
        private void SaveToTextFile()
        {
            StringBuilder TextBuilder = new StringBuilder();
            foreach (var playerTable in BilyarTables)
            {
                TextBuilder.AppendLine("Table " + playerTable.TableNumber);
                foreach (var TextPlayer in playerTable.BilyarPlayers)
                {
                    TextBuilder.AppendLine(TextPlayer.Name + " | " + TextPlayer.Payment.ToString
                        (CultureInfo.InvariantCulture));
                }

            }
            File.WriteAllText(TextFilePath, TextBuilder.ToString());
        }
        public void AddPlayerToTable(int TableNumber, string name)
        {
            var PlayerTable = GetTables(TableNumber);
            if (PlayerTable != null && PlayerTable.BilyarPlayers.Count < 2)
            {
                PlayerTable.BilyarPlayers.Add(new Player(name));
                SaveToTextFile();
            }
        }
        public bool RemovePlayer(int TableNumber)
        {
            var PlayerTable = GetTables(TableNumber);
            if (PlayerTable != null)
            {
                var playerToRemove = GetTables(TableNumber);
                if (playerToRemove != null)
                {
                    PlayerTable.BilyarPlayers.Clear();
                    SaveToTextFile();
                    return true;
                }
            }
            return false;
        }
        public List<BTables> GetAllTables()
        {
            return new List<BTables>(BilyarTables);
        }
        public BTables GetTables(int Number)
        {
            return BilyarTables.FirstOrDefault(t => t.TableNumber == Number);

        }
        public bool UpdatePayment(int tableNumber, string playerName, int payment)
        {
            var PlayerTable = GetTables(tableNumber);
            if (PlayerTable != null)
            {
                var player = PlayerTable.BilyarPlayers.FirstOrDefault(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
                if (player != null)
                {
                    player.Payment = payment;
                    SaveToTextFile();
                    return true;
                }
            }
            return false;
        }
    }
}

