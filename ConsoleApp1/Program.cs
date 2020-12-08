using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Menu Generator");
            Menu myMenu = new Menu()
            {
                RestaurantName = "The Nice Spot",
                LastUpdated = DateTime.Today
            };
            MenuItems myItem = new MenuItems("Toasted Ravioli", (decimal)14.99, "appetizer");
            myMenu.AddItem(myItem);
            myMenu.PrintMenu();

        }
    }
}
