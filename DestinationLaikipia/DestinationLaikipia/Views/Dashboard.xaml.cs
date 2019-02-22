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
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();

			dashboard_wildlife_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.rhino.webp");
			dashboard_shopping_center_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.shopping_mall.webp");
			dashboard_investments_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.money.webp");
			dashboard_accommodation_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.hotel.webp");
			dashboard_events_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.people.webp");
			dashboard_carhire_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.car_image.webp");
		}
	}
}