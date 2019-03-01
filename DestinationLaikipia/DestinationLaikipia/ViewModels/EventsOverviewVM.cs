using DestinationLaikipia.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DestinationLaikipia.ViewModels
{
    public class EventsOverviewVM
    {
        public Image EventImageVM { get; set; }

        public string Event_ContentVM { get; set; }

        public string Event_TitleVM { get; set; }

        public string Phone_NumberVM { get; set; }

        public string EmailVM { get; set; }

        public DateTime DateVM { get; set; }

        public ObservableCollection<Event> Employees
        {
            get;
            set;
        }
    }
}
