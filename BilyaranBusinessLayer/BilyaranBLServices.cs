using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using BilyaranServices;
using BilyaranCommon;
using Microsoft.Extensions.Options; 

namespace BilyaranBusinessLayer
{

    public class BilyaranBLServices
    {
        private BilyarLogicService bilyaranDL = new BilyarLogicService();
        private readonly SmtpSettings _smtpSettings; 
        public BilyaranBLServices(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }
        public BilyaranBLServices()
        {
        }
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
            using var client = new SmtpClient(_smtpSettings.Host, _smtpSettings.Port)
            {
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                EnableSsl = true
            };
            client.Send(_smtpSettings.FromAddress, to, subject, body);
        }
    }
}