using System.Collections.ObjectModel;
using kyllianApp.Models;
using kyllianApp.Services;

namespace kyllianApp.ViewModels;

public class CharactersViewModel : BaseViewModel
{
    public ObservableCollection<Character> Characters { get; set; } = new();
    private readonly ApiService _apiService = new();

    public CharactersViewModel()
    {
        _ = LoadCharacters();
    }

    private async Task LoadCharacters()
    {
        IsBusy = true;
        var characters = await _apiService.GetCharactersAsync();
        Characters.Clear();
        foreach (var character in characters)
            Characters.Add(character);
        IsBusy = false;
    }
}
