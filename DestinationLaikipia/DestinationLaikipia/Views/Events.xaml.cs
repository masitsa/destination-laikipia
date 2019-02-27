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
	public partial class Events : ContentPage
	{
		public Events ()
		{
			InitializeComponent ();

			events_front_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
			events_one_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
			events_two_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
			events_three_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
			events_four_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");

			Events_Image_Front_TapGesture();
			Events_One_Front_TapGesture();
			Events_Two_Front_TapGesture();
			Events_Three_Front_TapGesture();
			Events_Four_Front_TapGesture();

		}

		//Goes to the next page when image is tapped
		public void Events_Image_Front_TapGesture()
		{
			var events_front_tap = new TapGestureRecognizer();
			events_front_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new SingleViewEvents());
			};
			events_front_image.GestureRecognizers.Add(events_front_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_One_Front_TapGesture()
		{
			var events_one_tap = new TapGestureRecognizer();
			events_one_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new SingleViewEvents());
			};
			events_one_image.GestureRecognizers.Add(events_one_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_Two_Front_TapGesture()
		{
			var events_two_tap = new TapGestureRecognizer();
			events_two_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new SingleViewEvents());
			};
			events_two_image.GestureRecognizers.Add(events_two_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_Three_Front_TapGesture()
		{
			var events_three_tap = new TapGestureRecognizer();
			events_three_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new SingleViewEvents());
			};
			events_three_image.GestureRecognizers.Add(events_three_tap);
		}

		//Goes to the next page when image is tapped
		public void Events_Four_Front_TapGesture()
		{
			var events_four_tap = new TapGestureRecognizer();
			events_four_tap.Tapped += (s, e) =>
			{
				// App.Current.MainPage = MyContentPage;
				App.Current.MainPage = new NavigationPage();
				App.Current.MainPage.Navigation.PushAsync(new SingleViewEvents());
			};
			events_four_image.GestureRecognizers.Add(events_four_tap);
		}

	}
}