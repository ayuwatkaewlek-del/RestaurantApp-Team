using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "Tee noi", Type = "Shabu", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "Somtam", Type = "Esan food", Rating = 4.8 },
        new Restaurant { Name = "BBQ Plaza", Type = "Japanese BBQ", Rating = 4.8 }
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.Write("Enter Restaurant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Restaurant Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Restaurant Rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            Restaurant newRestaurant = new Restaurant()
            {
                Name = name,
                Type = type,
                Rating = rating
            };

            restaurants.Add(newRestaurant);

            Console.WriteLine("Restaurant Added Successfully!");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }
    }

}
