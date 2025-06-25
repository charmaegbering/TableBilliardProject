    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using BilyaranServices;
    using BilyaranCommon;


    namespace BilyaranServices
    {
        public class BilyarLogicService
        {
            private IBilyarDataService BilyarData;
            public BilyarLogicService()
            {
               //BilyarData = new BilyarInMemoryDataService();
               // BilyarData = new BilyarJsonFileDataService();
                //BilyarData = new BilyarTextFileDataService();
                BilyarData = new BilyaranSQL();

            }

           public List<BTables> GetAllTables()
            {
                return BilyarData.GetAllTables();
            }
            public BTables GetTableByNumber(int tableNumber)
            {
                return BilyarData.GetTables(tableNumber);
            }
           public void AddPlayerToTable(int tableNumber, string playerName)
            {
                BilyarData.AddPlayerToTable(tableNumber, playerName);
            }
            public bool RemovePlayer(int tableNumber)
            {
                return BilyarData.RemovePlayer(tableNumber);
            }
           public bool UpdatePayment(int tableNumber, string playerName, int payment)
            {
                return BilyarData.UpdatePayment(tableNumber, playerName, payment);
            }

        }
    }


