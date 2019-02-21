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
        ItemListViewModel itemlistviewmodel;
		public Wildlife ()
		{
			InitializeComponent ();
            itemlistviewmodel = new ItemListViewModel();
            BindingContext = itemlistviewmodel;
        }
	}
}