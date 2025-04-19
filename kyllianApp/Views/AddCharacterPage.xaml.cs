using Android.AdServices.Common;
using kyllianApp.ViewModels;

namespace kyllianApp.Views;

public partial class AddCharacterPage : ContentPage
{
    public AddCharacterPage()
    {
        InitializeComponent();
        BindingContext = new AddCharacterViewModel(AppData.SharedCharacters);
    }
}


