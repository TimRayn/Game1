using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuessNumb
{
    public class NumbVars
    {
        public void StartGame()
        {
            Console.WriteLine("Начать игру?\n(Y/N)");
            string key = Console.ReadLine()?.ToLower();
            if (key == "y")
            {
                StartYes();
            }
            else if (key == "n")
            {
                Environment.Exit(0);
            }
        }

        public void ContinueGame()
        {
            Console.WriteLine("Продолжить игру?\n(Y/N)");
            string key = Console.ReadLine()?.ToLower();
            if (key == "y")
            {
                StartYes();
            }
            else if (key == "n")
            {
                Console.WriteLine("Ладно, как хочешь, было весело. Пока.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void StartYes()
        {
        Console.WriteLine("Привет, давай поиграем! Я загадаю число от 1 до 9, а ты будешь угадывать!\nНо у тебя будет только три попытки.\nНу что, начнем?\n(Y/N)");
            string key = Console.ReadLine()?.ToLower();
            if (key == "y")
            {
                Variants();
            }
            else if (key == "n")
            {
                FuckYou();
            }
        }

        public void Variants()
        {
            
            Random rand = new Random();
            int number = rand.Next(1, 10);
            Console.WriteLine("Отлично, поехали! Итак...");
            Thread.Sleep(900);
            Console.WriteLine("...");
            Thread.Sleep(900);
            Console.WriteLine("...");
            Thread.Sleep(900);
            Console.WriteLine("...\nЯ загадал! Какое число?");
            string key = Console.ReadLine();
            try
            {
                var numKey = Int32.Parse(key);
                if (numKey == number)
                {

                }
            }
            catch
            {
                Console.WriteLine("Это вообще не число! Ты неприятный(ая). С тобой неинтересно играть.\n(Вы проиграли)");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void FuckYou()
        {
            Console.WriteLine("\nНу и пошел(а) ты нахуй!\n(Вы проиграли.)");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
