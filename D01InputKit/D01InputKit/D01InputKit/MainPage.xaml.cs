using D01InputKit.Views;
using System;
using Xamarin.Forms;

namespace D01InputKit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void rb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageRadioButton());
        }
    }
}
