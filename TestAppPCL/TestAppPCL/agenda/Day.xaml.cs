using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppPCL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DayNavigationPage : NavigationPage
	{
		public DayNavigationPage() : base(new Day()) {}
	}

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Day : ContentPage
	{
		public Day ()
		{
			InitializeComponent ();
			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			switcher.Toggled += switcher_Toggled;
			this.BindingContext = new[] { switcher };
		}

		void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			//if (((ListView)sender).SelectedItem != null)
			//{
			//	((ListView)sender).SelectedItem = null; // de-select the row
			//}
		}


		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if(e.SelectedItem == null)
			{
				((ListView)sender).SelectedItem = null;
				return;
			}
			DisplayAlert("test", e.SelectedItem.ToString(), "ok");
		}

		void switcher_Toggled(object sender, ToggledEventArgs e)
		{
			
		}
	}



	
}