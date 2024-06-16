using System;


namespace controlExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopMessage = null;
            string stopWord = "exit";
            bool canContinueCycle = true;

            Console.WriteLine($"Вы входите в заведение.\nЕсли хотите выйти напишите {stopWord}.");

            while (canContinueCycle)
            {
                Console.WriteLine("Мартышка хлопает в тарелки.");
                Console.WriteLine("Введите стоп слово:");

                stopMessage = Console.ReadLine();

                canContinueCycle = stopWord != stopMessage;

                if (canContinueCycle == true)
                {
                    Console.WriteLine("Вы ввели неверное стоп-слово.");
                }
            }

            Console.WriteLine("Вы покинули заведение и получили футболку в подарок.");
        }
    }
}
