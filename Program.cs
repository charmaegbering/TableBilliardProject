using System;
using BilyaranServices;
using BilyaranBusinessLayer;
using BilyaranCommon;
using System.Collections.Generic;

namespace TableBilliardProject
{
        class Program
        {
        static BilyaranBLServices bilyaranBL = new BilyaranBLServices();     
            static void Main()
            {
                bool running = true;
                while (running)
                {
                    BilyarOptions();
                    int Options = Convert.ToInt16(Console.ReadLine());
                    switch ((OptionEnum)Options)
                    {
                        case OptionEnum.AddPlayerToATable:
                            AddPlayers();
                            break;
                        case OptionEnum.RemovePlayerFromATable:
                            RemovePlayers();
                            break;
                        case OptionEnum.DisplayAllTables:
                            ShowTables();
                            break;
                        case OptionEnum.UpdatePrice:
                            UpdatePayment();
                            break;
                        case OptionEnum.SendNotification:
                            SendNotification();
                            break;
                                case OptionEnum.Exit:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Option. Please Enter [1-5] ONLY");
                            break;
                    }
                }
                Console.WriteLine("Closing System....");
            }
            static void BilyarOptions()
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Welcome to Billiard Table Management System!");
                Console.WriteLine("=============================");
                Console.WriteLine("[1] Add Players to a Table");
                Console.WriteLine("[2] Remove Players from a Table");
                Console.WriteLine("[3] Display All Tables");
                Console.WriteLine("[4] Update Payment from a Table");
                Console.WriteLine("[5] Send Notification");
                Console.WriteLine("[6] Exit");
                Console.WriteLine("=============================");
                Console.Write("Please Select From [1-6]: ");
            }
            static void AddPlayers()
            {
                Console.WriteLine("=============================");
                Console.Write("Please Enter a Table Number [1-4]: ");
                if (!int.TryParse(Console.ReadLine(), out int TableNumber) || TableNumber < 1 || TableNumber > 4)
                {
                    Console.WriteLine("Invalid Table Number. Please Enter [1-4] ONLY.");
                    return;
                }
                Console.Write("Please Enter Player One Name: ");
                string PlayerOne = Console.ReadLine();
                Console.Write("Please Enter Player Two Name: ");
                string PlayerTwo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(PlayerOne) || string.IsNullOrWhiteSpace(PlayerTwo))
                {
                    Console.WriteLine("Player names cannot be empty. Please try again.");
                    return;
                }
            bool added = bilyaranBL.AddPlayerToTable(TableNumber, PlayerOne, PlayerTwo);

                if (added)
                    Console.WriteLine("Players added successfully to Table " + TableNumber);
                else
                    Console.WriteLine("Could not add players. Table may already be full.");
            }
            static void RemovePlayers()
            {
                Console.WriteLine("=============================");
                Console.Write("Please Enter a Table Number [1-4]: ");
                if (!int.TryParse(Console.ReadLine(), out int TableNumber) || TableNumber < 1 || TableNumber > 4)
                {
                    Console.WriteLine("Invalid Table Number. Please Enter [1-4] ONLY.");
                    return;
                }
                bool removed = bilyaranBL.RemovePlayerFromATable(TableNumber);
                if (removed)
                    Console.WriteLine("Players are removed successfully from Table " + TableNumber);
                else
                    Console.WriteLine("Failed to remove players. Table might already be empty.");
            }
            static void ShowTables()
            {
            List<BTables> bTables = bilyaranBL.GetAllTables();
                foreach (var tables in bTables)
                {
                    Console.WriteLine("--- Table Number: " + tables.TableNumber + ": " + (tables.IsOccupied ? "Occupied" : "Available"));
                    if (tables.BilyarPlayers.Count > 0)
                    {
                        foreach (var player in tables.BilyarPlayers)
                        {
                            Console.WriteLine("Player Name: " + player.Name + " || " + " Amount: " + player.Payment + "\n =================");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Current Players in the Table");
                    }
                }
            }
            static void UpdatePayment()
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Enter Table Number [1-4]: ");
                if (!int.TryParse(Console.ReadLine(), out int TableNumber) || TableNumber < 1 || TableNumber > 4)
                {
                    Console.WriteLine("Invalid Table Number. Please Enter [1-4] ONLY.");
                    return;
                }
                Console.Write("Please Enter Player Name: ");
                string PlayerName = Console.ReadLine();
                Console.Write("Enter Total Amount: ");
                if (!int.TryParse(Console.ReadLine(), out int Payment) || Payment < 0)
                {
                    Console.WriteLine("Invalid Payment Amount. Please Enter a valid number.");
                    return;
                }

                bool updated = bilyaranBL.UpdatePayment(TableNumber, PlayerName, Payment);

                if (updated)
                    Console.WriteLine("Payment updated successfully for Player " + PlayerName + " at Table " + TableNumber);
                else
                    Console.WriteLine("Failed to update payment. Player may not exist on this table.");
            }
            static void SendNotification()
            {
                Console.Write("Enter recipient email: ");
                string to = Console.ReadLine();
                Console.Write("Enter subject: ");
                string subject = Console.ReadLine();
                Console.Write("Enter message body: ");
                string body = Console.ReadLine();

                try
                {
                    bilyaranBL.SendNotification(to, subject, body);
                    Console.WriteLine("Notification sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to send notification: " + ex.Message);
                }
            }
        }
    }
    enum OptionEnum
    {
        AddPlayerToATable = 1,
        RemovePlayerFromATable,
        DisplayAllTables,
        UpdatePrice,
        SendNotification, 
        Exit
    }