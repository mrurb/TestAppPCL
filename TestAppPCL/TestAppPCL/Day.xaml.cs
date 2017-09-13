using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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
		}
	}

	
}