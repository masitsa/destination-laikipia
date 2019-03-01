using DestinationLaikipia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DestinationLaikipia.ViewModels
{
   public class WildlifeViewModel 
    {
        public List<Wildlife> wildlifes { get; set; }

        public WildlifeViewModel()
        {
            wildlifes = new Wildlife().Getwildlife();
            
        }
    }
}


