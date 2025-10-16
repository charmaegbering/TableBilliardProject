using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using BilyaranServices;
using BilyaranCommon;

namespace BilyaranBusinessLayer
{
    
    public class BilyaranBLServices
    {
        private BilyarLogicService bilyaranDL = new BilyarLogicService();

        public bool AddPlayerToTable(int tableNumber, string playerOne, string playerTwo)
        {
            var table = bilyaranDL.GetTableByNumber(tableNumber);
            if (table != null && table.BilyarPlayers.Count < 2)
            {
                bilyaranDL.AddPlayerToTable(tableNumber, playerOne);
                bilyaranDL.AddPlayerToTable(tableNumber, playerTwo);
                return true;
            }
            return false;
        }
        public bool RemovePlayerFromATable(int tableNumber)
        {
            return bilyaranDL.RemovePlayer(tableNumber);
        }
        public bool UpdatePayment(int tableNumber, string playerName, int price)
        {
            return bilyaranDL.UpdatePayment(tableNumber, playerName, price);
        }
        public List<BTables> GetAllTables()
        {
            return bilyaranDL.GetAllTables();
        }

        public void SendNotification(string to, string subject, string body)
        {
            using var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("f43b1c8d6c6f74", "722679699e36d5"),
                EnableSsl = true
            };
            client.Send("charmaegbering10@gmail.com", to, subject, body);
        }
    }
}
