using DestinationLaikipia.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DestinationLaikipia.ViewModels
{
    class WildlifeSingleViewModel
    {
        public Image SiteImage { get; set; }

        public string Site_Details { get; set; }

        public string SitePhone_Number { get; set; }

        public string Site_Email { get; set; }

        public ObservableCollection<Wildlife> Employees
        {
            get;
            set;
        }

    }
}
//events

