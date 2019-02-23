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
	public partial class Dashboard : CarouselPage
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


			Wildlife_TapGesture();
			Accommodation_TapGesture();
			Events_TapGesture();
		}

		// Code that navigates to wildlife page when icon is tapped
		public void Wildlife_TapGesture()
		{          
			var wildlife_tap = new TapGestureRecognizer();
			wildlife_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new Wildlife());
			};
			dashboard_wildlife_image.GestureRecognizers.Add(wildlife_tap);
		}

		// Code that navigates to accommodation page when image is tapped
		public void Accommodation_TapGesture()
		{
			var accommodation_tap = new TapGestureRecognizer();
			accommodation_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new Accommodation());
			};
			dashboard_accommodation_image.GestureRecognizers.Add(accommodation_tap);
		}

		// Code that navigates to events page when image is tapped
		public void Events_TapGesture()
		{
			var events_tap = new TapGestureRecognizer();
			events_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new Events());
			};
			dashboard_events_image.GestureRecognizers.Add(events_tap);
		}

		
	}
}