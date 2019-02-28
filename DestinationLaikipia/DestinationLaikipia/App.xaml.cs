using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DestinationLaikipia.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DestinationLaikipia
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new MainPage();
            
=======
              //MainPage = new MainPage();
            MainPage = new AccommodationSingleView();
>>>>>>> b5430268314ef77aa0288526bb5b6c7d6e927a71
        }
       

    }
}
