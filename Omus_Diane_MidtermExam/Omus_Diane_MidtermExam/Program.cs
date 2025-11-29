using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omus_Diane_MidtermExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Default Information
            string defaultPin = "112925";
            double balance = 123456.78;
            int maxAttempts = 3;
            int attempts = 0;
            bool isAuthenticated = false;
            Console.OutputEncoding = Encoding.UTF8;

            // Welcome Message 
            Console.Clear();
            string welcomeMessage = "WELCOME TO OUR ATM MACHINE!";
            Console.WriteLine($"|{" ", -7} {welcomeMessage, -35}|");

            // PIN Authentication
            while (attempts < maxAttempts && !isAuthenticated)
            {
                try
                {
                    Console.Write("PLEASE ENTER YOUR 6-DIGIT PIN: ");
                    string pinInput = Console.ReadLine();

                    if (pinInput == defaultPin)
                    {
                        isAuthenticated = true;
                        Console.WriteLine("PIN ACCEPTED. ACCESS GRANTED.");
                    }
                    else if (attempts == maxAttempts && !isAuthenticated)
                    {
                        Console.WriteLine("MAXIMUM ATTEMPTS REACHED. YOUR ACCOUNT IS LOCKED. PLEASE CONTACT THE BANK.");
                        return;
                    } 
                    else
                    {
                        attempts++;
                        Console.WriteLine($"INCORRECT PIN. YOU HAVE {maxAttempts - attempts} ATTEMPT(S) LEFT.");
                    } 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"AN ERROR OCCURRED: {ex.Message}");
                }

            } 
            // Transaction Loop 
            bool continueTransactions = true;
            while (isAuthenticated && continueTransactions)
            {
                // Display Main Menu 
                Console.Clear();
                Console.WriteLine($"| {" ",-7} {"MAIN MENU",-34}|");
                Console.WriteLine($"| {"1. VIEW BALANCE",-42}|");
                Console.WriteLine($"| {"2. ACTIVATE ENROLLMENTS",-42}|");
                Console.WriteLine($"| {"3. PIN SERVICES",-42}|");
                Console.WriteLine($"| {"4. PAY BILL",-42}|");
                Console.WriteLine($"| {"5. WITHDRAW MONEY",-42}|");
                Console.WriteLine($"| {"6. EXIT/CANCEL",-42}|");
                Console.WriteLine(" ");

                Console.Write("PLEASE SELECT A TRANSACTION (1-6): ");
                string mainMenu = Console.ReadLine();
                int menuChoice = Convert.ToInt32(mainMenu);

                try
                {

                    switch (menuChoice)
                    {
                        case 1:
                            // View Balance
                            Console.Clear();
                            Console.WriteLine($"| {" ",-7} {"VIEW BALANCE",-35} |");
                            Console.WriteLine($"| {"YOUR CURRENT BALANCE IS: ",-30} {balance,12:C2} |");

                            break;

                        case 2:
                            // Activate Enrollments 
                            Console.Clear();
                            Console.WriteLine($"|{" ",-7} {"ACTIVATE ENROLLMENTS",-35}|");
                            Console.WriteLine(" ");
                            Console.WriteLine($"|{"AVAILABLE ENROLLMENTS TO ACTIVATE.",-42}|");
                            Console.WriteLine($"| {"1. MOBILE NUMBER",-42}|");
                            Console.WriteLine($"| {"2. EMAIL ADDRESS",-42}|");
                            Console.WriteLine($"| {"3. NEWLY ENROLLED DEVICE",-42}|");
                            break;
                        case 3: 
                            // PIN Services
                            Console.Clear();
                            break;
                        case 4: 
                            // Pay Bills
                            Console.Clear();
                            break;
                        case 5: 
                            // Withdraw Money
                            Console.Clear();
                            break;
                        case 6:
                            // Exit 
                            Console.Clear();
                            break;
                    }   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured: {ex.Message}"); 
                }
            }   
        }
    }
}

