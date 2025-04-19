using kyllianApp.Models;
using System.ComponentModel;

namespace kyllianApp.Views;

[QueryProperty(nameof(Character), "Character")]
public partial class CharacterDetailPage : ContentPage
{
    private Character character;
    public Character Character
    {
        get => character;
        set
        {
            character = value;
            LoadCharacterData();
        }
    }

    public CharacterDetailPage()
    {
        InitializeComponent();
    }

    private void LoadCharacterData()
    {
        if (Character == null) return;

        CharacterImage.Source = Character.Image;
        CharacterName.Text = Character.Name;
        CharacterStatus.Text = $"Statut : {Character.Status}";
        CharacterSpecies.Text = $"Espèce : {Character.Species}";
        CharacterGender.Text = $"Genre : {Character.Gender}";
    }
}
