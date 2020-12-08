using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItems> menuList;
        public String RestaurantName { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu ()
        {
            menuList = new List<MenuItems>();
        }

       public void  PrintMenu ()
        {
            //loop through menulist
            foreach (MenuItems m in menuList)
            {
                Console.Write("Menu Item : " + m.Description + "\nPrice : " + m.Price.ToString("c"));
                Console.Write("\nCategory: " + m.Category);
                Console.Write("\nDate Added to Menu: " + m.DateAdded.ToString("MMMM dd, yyyy"));

            }
            //compare Date Added > Last Update print new next to it
        }

        public void AddItem(MenuItems item)
        {
            menuList.Add(item);
        }
    }
}
