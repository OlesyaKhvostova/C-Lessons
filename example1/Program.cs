using System;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Прием у врача");
            Console.WriteLine("Покупка лекарств");
            Console.WriteLine("Прогулка в парке");
            Console.Write("Вот так я провела свой день");
            Console.Write(name);
        }
    }
}
