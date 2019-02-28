using DestinationLaikipia.Model;
using DestinationLaikipia.ViewModels;
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
	public partial class EventsOverview : ContentPage
	{
		public EventsOverview ()
		{
			InitializeComponent ();
            BindingContext = new EventsOverviewVM();

            events_front_detail_image.Source = ImageSource.FromResource("DestinationLaikipia.Assets.Images.front_image.jpg");
        }
        
    }
}