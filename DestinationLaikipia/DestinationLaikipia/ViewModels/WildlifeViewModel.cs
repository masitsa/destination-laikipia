using DestinationLaikipia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DestinationLaikipia.ViewModels
{
   public class WildlifeViewModel 
    {
        public List<Wildlife> Wildlifes { get; set; }

        public WildlifeViewModel()
        {
            Wildlifes = new Wildlife().Getwildlife();
            
        }
    }
}


