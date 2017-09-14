using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppPCL
{
   public class Agenda : ContentPage
    {
	    public Agenda()
	    {
			var listView = new ListView();
			listView.ItemsSource = new[] {"a", "b", "c"};
			
	    }

    }
}
