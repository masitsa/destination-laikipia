using DestinationLaikipia.Models;
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
	public partial class Wildlife : ContentPage
	{
		WildlifeViewModel wildlifeview;

        public static List<Models.Wildlife> ItemsSource { get; set; }

        public Wildlife ()
		{
			InitializeComponent ();
            wildlifeview = new WildlifeViewModel();
            Wildlife.ItemsSource = wildlifeview.wildlifes;
			BindingContext = wildlifeview;
		}
	}
}
