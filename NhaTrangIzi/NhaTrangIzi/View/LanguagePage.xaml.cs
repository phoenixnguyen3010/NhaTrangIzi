using System;
using NhaTrangIzi.interfaces;
using Xamarin.Forms;

namespace NhaTrangIzi.View
{
    public partial class LanguagePage : ContentPage
    {
        public LanguagePage()
        {
            InitializeComponent();
        }

        private async void btnLanguage_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == btnVietNam)
            { 
                //DisplayAlert("Language", "You choose VietNam", "OK");
                await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
            }
            else if (button == btnEngland)
            {
                DisplayAlert("Language", "You choose England", "OK");
            }
            else if (button == btnRussia)
            {
                DisplayAlert("Language", "You choose Russia", "OK");
            }
            else
            {
                DisplayAlert("Language", "You choose China", "OK");
            }
        }

        private void btnExit_OnClick(object sender, EventArgs e)
        {
            if (Device.OS == TargetPlatform.Android)
            {
                DependencyService.Get<IAndroidMethods>().CloseApp();
            }

        }

        protected override bool OnBackButtonPressed()
        {
            if (Device.OS == TargetPlatform.Android)
                DependencyService.Get<IAndroidMethods>().CloseApp();

            return base.OnBackButtonPressed();
        }
    }
}
