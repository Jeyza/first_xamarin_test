using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace first_xamarin_test
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Title", "Hello World", "OK");
		}
    }
}
