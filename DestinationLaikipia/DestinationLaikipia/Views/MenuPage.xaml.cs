using DestinationLaikipia.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DestinationLaikipia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            thumbnail.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.mtkenyaice.webp");
            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Wildlife, Title="Wildlife", Icon = "ic_wildlife.png"},
                new HomeMenuItem {Id = MenuItemType.Accommodation, Title="Accommodation", Icon = "ic_accommodation.png" },
                new HomeMenuItem {Id = MenuItemType.Events, Title="Events", Icon = "ic_events.png" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;
                
                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };

        }

        
    }
}