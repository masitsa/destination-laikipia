using DestinationLaikipia.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DestinationLaikipia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

<<<<<<< HEAD
            MenuPages.Add((int)MenuItemType.MainPage, (NavigationPage)Detail);

=======

            MenuPages.Add((int)MenuItemType.Wildlife, (NavigationPage)Detail);
            
>>>>>>> 4bafbd0a48a88f5e5e500b97eeb10d47cd19d050
        }


        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.MainPage:
                        MenuPages.Add(id, new NavigationPage(new MainPage()));
                        break;
                    case (int)MenuItemType.Wildlife:
                        MenuPages.Add(id, new NavigationPage(new Wildlife()));
                        break;
                    case (int)MenuItemType.Accommodation:
                        MenuPages.Add(id, new NavigationPage(new Accommodation()));
                        break;
                    case (int)MenuItemType.Events:
                        MenuPages.Add(id, new NavigationPage(new Events()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
            
        }

    }
}