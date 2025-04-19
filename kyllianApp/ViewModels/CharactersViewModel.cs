using System.Collections.ObjectModel;
using kyllianApp.Models;
using kyllianApp.Services;

namespace kyllianApp.ViewModels;

public class CharactersViewModel : BaseViewModel
{
    public ObservableCollection<Character> Characters => AppData.SharedCharacters;

    public CharactersViewModel()
    {
        _ = LoadCharacters();
    }

    private async Task LoadCharacters()
    {
        if (Characters.Count > 0) return; // éviter de doubler les données

        var apiService = new ApiService();
        var characters = await apiService.GetCharactersAsync();

        foreach (var character in characters)
            Characters.Add(character);
    }
}


