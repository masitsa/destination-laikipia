using DestinationLaikipia.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace DestinationLaikipia.ViewModels
{
    public class AccommodationViewModel
    {
        //Requirement of this class is to display a list of speakers
        public List<Accommodation> Accommodations { get; set; }

        //constructor  
        public AccommodationViewModel()
        {
            Accommodations = new Accommodation().GetAccommodations();
        }
        
    }
}
