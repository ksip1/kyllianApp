using kyllianApp.Views;

namespace kyllianApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(CharacterDetailPage), typeof(CharacterDetailPage));

        Routing.RegisterRoute(nameof(GifPage), typeof(GifPage));

    }
}
