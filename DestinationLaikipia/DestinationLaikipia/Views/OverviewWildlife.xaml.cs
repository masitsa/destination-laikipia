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
	public partial class OverviewWildlife : ContentPage
	{
         OverviewWildlife singlesiteview;

        public OverviewWildlife ()
		{
			InitializeComponent ();
            singlesiteview = new OverviewWildlife();
            BindingContext = singlesiteview;
           
        }
    }
	
}