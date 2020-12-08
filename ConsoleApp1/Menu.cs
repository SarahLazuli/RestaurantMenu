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

       public void  PrintMenu ()
        {
            //loop through menulist
            //compare Date Added > Last Update print new next to it
        }

        public void AddItem(MenuItems item)
        {
            menuList.Add(item);
        }
    }
}
