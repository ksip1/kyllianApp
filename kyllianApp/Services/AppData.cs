using System.Collections.ObjectModel;
using kyllianApp.Models;

namespace kyllianApp;

public static class AppData
{
    public static ObservableCollection<Character> SharedCharacters { get; set; } = new();
}

