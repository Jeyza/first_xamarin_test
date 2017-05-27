using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;

namespace first_xamarin_test
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }
    }
}
