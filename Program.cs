using System;

namespace UserSurvey
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вас зовут {name} и вам {age} (год, года, лет).");

            Console.Write("Введите вашу дату рождения: ");
            string birtdate = Console.ReadLine();

            Console.WriteLine("Вы родились - {0} ", birtdate);

            Console.ReadKey();
        }
    }
}
