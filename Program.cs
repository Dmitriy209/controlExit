using System;


namespace controlExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopMessage = null;
            string stopWord = "exit";
            bool stopCycle = true;

            Console.WriteLine("Вы входите в заведение.\nЕсли хотите выйти напишите exit.");

            while (stopWord != stopMessage)
            {
                Console.WriteLine("Мартышка хлопает в тарелки.");
                Console.WriteLine("Введите стоп слово:");

                stopMessage = Console.ReadLine();

                if (stopWord != stopMessage)
                {
                    Console.WriteLine("Вы ввели неверное стоп-слово.");
                }
            }
            Console.WriteLine("Вы покинули заведение и получили футболку в подарок.");
        }
    }
}
