using Microsoft.Maui.Controls;

namespace kyllianApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void OnGifButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GifPage));
        }

    }
}
