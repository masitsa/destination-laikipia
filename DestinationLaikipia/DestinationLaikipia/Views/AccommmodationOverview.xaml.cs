using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DestinationLaikipia.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccommmodationOverview : ContentPage
	{
		public AccommmodationOverview ()
		{
			InitializeComponent ();

            HotelImageUrl.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.Le_Rustique.jpg");
        }
	}
}