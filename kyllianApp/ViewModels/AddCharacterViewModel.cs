using System.Windows.Input;
using kyllianApp.Models;
using System.Collections.ObjectModel;

namespace kyllianApp.ViewModels;

public class AddCharacterViewModel : BaseViewModel
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Status { get; set; }
    public string Image { get; set; }

    public ObservableCollection<Character> Characters { get; }

    public ICommand AddCharacterCommand { get; }

    public AddCharacterViewModel(ObservableCollection<Character> characters)
    {
        Characters = characters;
        AddCharacterCommand = new Command(AddCharacter);
    }

    private async void AddCharacter()
    {
        var newCharacter = new Character
        {
            Name = Name,
            Species = Species,
            Status = Status,
            Image = Image
        };

        Characters.Add(newCharacter);

        await Shell.Current.GoToAsync(".."); 
    }
}
