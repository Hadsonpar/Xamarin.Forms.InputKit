using D02InputKit.Views;
using System;
using Xamarin.Forms;

namespace D02InputKit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void cb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageCheckBox());
        }
    }
}
