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

            MainPage = new MainPage();

        }
       

    }
}
