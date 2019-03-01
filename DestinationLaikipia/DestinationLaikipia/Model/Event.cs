using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DestinationLaikipia.Model
{
    public class Event
    {
        public int Id { get; set; }

        public Image Event_Image{ get; set; }

        public string Date { get; set; }

        public string Events_Title { get; set; }

        public string Events_Description { get; set; }

        public string Email { get; set; }

    }
}
