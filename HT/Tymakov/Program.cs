using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Tymakov
{
    class MainClass
    {
        /// <summary>
        /// Writes "> " in start of the line.
        /// </summary>
        static void Offer()
        {
            Console.Write("> ");
        }

        /// <summary>
        /// Writes a number of the task.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="number">Number of the task.</param>
        static void Message(string message, int number)
        {
            Console.WriteLine("\nLet's check problem #{0}\nThis program {1}\nPress any to continue...", number, message);
            Console.ReadKey();
        }

        /// <summary>
        /// Reads the input int. If input incorrect it ass user to try again.
        /// </summary>
        /// <returns>The input int.</returns>
        /// <param name="positiveFlag">If set to <c>true</c> input must be positive.</param>
        /// <param name="nonZero">If set to <c>true</c> input must not be zero.</param>
        static int ReadInt(bool positiveFlag, bool nonZero)
        {
            int result = 1;
            bool term = true;
            while (term)
            {
                Offer();
                bool convert = int.TryParse(Console.ReadLine(), out result);
                bool positive = (result >= 0) || !positiveFlag;
                bool noZero = (result != 0) || !nonZero;
                if (convert && positive && noZero)
                {
                    term = false;
                }
                else if (!positive)
                {
                    Console.WriteLine("The input must be positive. Please, try again:");
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please, try again:");
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            #region Lab
            void Lab1()
            {
                Message("tests rewrited BankAccountType", 1);
                AccountType accountType1 = new AccountType(AccountType.BankAccountType.Current);
                accountType1.PutOn(400);
                AccountType accountType2 = new AccountType(AccountType.BankAccountType.Current);
                accountType2.PutOn(500);
                Console.WriteLine("\\\\Attempt to transfer 1000 from 0000 0000 0000 0000 to 0000 0000 0000 0001:");
                accountType2.TransferMoney(accountType1, 1000);
                Console.WriteLine("\\\\Attempt to transfer 200 from 0000 0000 0000 0000 to 0000 0000 0000 0001:");
                accountType2.TransferMoney(accountType1, 200);
            }
            #endregion

            #region HT
            void HT1()
            {
                Message("test rewrited Song class", 1);
                Song mySong = new Song();
                Console.WriteLine("Song mySong = new Song(); works! (check code)");
                List<Song> list = new List<Song>
                {
                    new Song("Megalovania", "Toby Fox"),
                    new Song("9th symphony", "Beethoven"),
                    new Song("Amogus drip remix", "Drop the Bassline"),
                    new Song("Forester", "Korol i Shut")
                };
                Console.WriteLine("Current playlist:");
                foreach (Song song in list)
                {
                    Console.WriteLine($"\t{song.Title()}");
                }
                Console.WriteLine("Comparing 1st and 2nd songs:");
                Console.WriteLine(list[0].Equals(list[1]));
            }
            #endregion

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru");
            bool run = true;
            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("||===========================<\\\\>===========================||");
                Console.WriteLine("Please, input \"HT\", if you want to check the HT solutions  or type \"exit\" to stop");
                Offer();
                string respond = Console.ReadLine().ToLower().Trim();
                if (respond.Equals("exit"))
                {
                    run = false;
                    continue;
                }
                if (respond.Equals("ht") || respond.Equals("нт")) // and russian-letters case
                {
                    HT1();
                }
                else
                {
                    Lab1();
                }
            }

            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
