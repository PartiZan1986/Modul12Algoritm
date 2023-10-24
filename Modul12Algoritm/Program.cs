using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.IO;
using System.Reflection;

namespace Modul12Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Login = "User1";
            user1.Name = "Alex";
            user1.IsPremium = false;

            User user2 = new User();
            user2.Login = "User2";
            user2.Name = "Ilya";
            user2.IsPremium = true;

            User user3 = new User();
            user3.Login = "User3";
            user3.Name = "Petr";
            user3.IsPremium = false;

            var userlist = new List<User>();
            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);

            foreach (var item in userlist)
            {
                if (!item.IsPremium)
                {
                    Console.WriteLine($"Приветствую {item.Name} ");
                    ShowAds();
                }
            }

            Console.ReadKey();
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
