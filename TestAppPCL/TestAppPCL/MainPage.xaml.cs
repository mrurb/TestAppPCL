﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppPCL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
			await DisplayAlert("Clicked!",
				"The button labeled '" + button.Text + "' has been clicked",
				"OK");
		}

		void OnButtonClicked2(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new TabbedPage1());
		}
	}
}
