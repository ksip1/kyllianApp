using kyllianApp.Models;
using kyllianApp.ViewModels;
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
    protected override void OnAppearing()
    {
        base.OnAppearing();

        ToolbarItems.Clear();
        ToolbarItems.Add(new ToolbarItem("Ajouter", null, async () =>
        {
            var vm = BindingContext as CharactersViewModel;
            await Shell.Current.Navigation.PushAsync(new AddCharacterPage
            {
                BindingContext = new AddCharacterViewModel(vm.Characters)
            });
        }));
    }

}

