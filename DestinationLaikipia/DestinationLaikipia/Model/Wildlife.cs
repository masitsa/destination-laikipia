using DestinationLaikipia.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace DestinationLaikipia.Models
{
    public class Wildlife
    {
        public string WildlifeName { get; set; }
        public string WildlifeDetails { get; set; }
        public string WildlifeImage  { get; set; }

        public List<Wildlife> Getwildlife()
        {
            List<Wildlife> wildlifes = new List<Wildlife>()
        {
            new Wildlife()
            {
                WildlifeName = "Ol Pejeta",
                WildlifeDetails = "Ol Pejeta prides itself on being at the cutting edge of conservation innovation. As the largest black rhino sanctuary in East Africa, and the only place in Kenya to see chimpanzees,",
                WildlifeImage = "olpejeta.png"

            },
             new Wildlife()
            {
                WildlifeName = " Mount Kenya Conservancy",
                WildlifeDetails = "The animal orphanage at the Mount Kenya Wildlife Conservancy is a unique facility to give orphaned, injured, neglected, abused or frightened wild animals a second chance. ",
                WildlifeImage = "mountkenyasconservancy.png"

            },
              new Wildlife()
            {
                WildlifeName = "Thompson Falls",
                WildlifeDetails = "Thomson falls are 72 meters, the mist feeding the dense forest below. You can check out the falls from above, or there’s a trail down to the bottom of the ravine.",
                WildlifeImage = "thompsonfalls.jpg"

            },
               new Wildlife()
            {
                WildlifeName = "Solio Game Reserve",
                WildlifeDetails = "The Solio Reserve is internationally recognised as the most successful private rhino breeding reserve in Kenya",
                WildlifeImage = "solio.jpg"

            },
                new Wildlife()
            {
                WildlifeName = "Sosian Reserve",
                WildlifeDetails = " offering pure wilderness, with more than 250 species of birdlife and an abundance of game species with four of the big five being found at Sosian Ranch, plus rare species such as Wild dogs, Jackson’s hartebeest and Grevy’s zebra.",
                WildlifeImage = "sosian.png"

            }
        };
            return wildlifes;
        }
    }
   
    //accommodation
   


    }
