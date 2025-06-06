using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilyaranCommon;
using BilyaranServices;

namespace BilyaranServices
{
    public interface IBilyarDataService
    {
        List<BTables> GetAllTables();
        BTables GetTables(int tableNumber);
        void AddPlayerToTable(int tableNumber, string PlayerName);
        bool RemovePlayer(int tableNumber);
        bool UpdatePayment(int tableNumber, string PlayerName, int payment);
    }
}
