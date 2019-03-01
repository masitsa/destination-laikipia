using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DestinationLaikipia.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DestinationLaikipia.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Accommodation : ContentPage
	{
        AccommodationViewModel vm;
        public Accommodation ()
		{
           
			InitializeComponent();
            vm = new AccommodationViewModel();

            BindingContext = vm;
			primary_accommodation_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.nanyuki_scenary.jpg");


		}
	}
}