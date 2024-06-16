using System;


namespace controlExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopMessage = null;
            string stopWord = "exit";
            bool canStopCycle = true;

            Console.WriteLine("Вы входите в заведение.\nЕсли хотите выйти напишите exit.");

            while (canStopCycle)
            {
                Console.WriteLine("Мартышка хлопает в тарелки.");
                Console.WriteLine("Введите стоп слово:");

                stopMessage = Console.ReadLine();

                canStopCycle = stopWord != stopMessage;

                if (canStopCycle == true)
                {
                    Console.WriteLine("Вы ввели неверное стоп-слово.");
                }
            }
            Console.WriteLine("Вы покинули заведение и получили футболку в подарок.");
        }
    }
}
