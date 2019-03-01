using System;
using System.Collections.Generic;
using System.Text;

namespace DestinationLaikipia.Models
{
    public enum MenuItemType
    {   
        MenuPages,
        MainPage,
        Wildlife,
        Accommodation,
        Events
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
