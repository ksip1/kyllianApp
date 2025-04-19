using kyllianApp.Models;
using kyllianApp.Views;

namespace kyllianApp.Views;

public partial class CharactersPage : ContentPage
{
    public CharactersPage()
    {
        InitializeComponent();
    }

    private async void OnCharacterTapped(object sender, EventArgs e)
    {
        if (sender is VisualElement element && element.BindingContext is Character selectedCharacter)
        {
            await Shell.Current.GoToAsync(nameof(CharacterDetailPage),
                new Dictionary<string, object>
                {
                { "Character", selectedCharacter }
                });
        }
    }
}

