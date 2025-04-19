using kyllianApp.Models;

namespace kyllianApp.Views;

public partial class FunZonePage : ContentPage
{
    private static readonly string[] Quotes =
    {
        "Wubba lubba dub dub !",
        "Je ne cherche pas de jugement, juste un oui ou un non. Saurez-vous assimiler une girafe",
        "Parfois, la science est plus un art qu'une science.",
        "Vivre, c'est tout risquer.",
        "Vos huées ne veulent rien dire, j'ai vu ce qui vous fait applaudir."
    };

    public FunZonePage()
    {
        InitializeComponent();
    }

    private void OnGetQuoteClicked(object sender, EventArgs e)
    {
        var random = new Random();
        var quote = Quotes[random.Next(Quotes.Length)];
        QuoteLabel.Text = $"\"{quote}\"";
    }

    private void OnPickRandomCharacterClicked(object sender, EventArgs e)
    {
        if (AppData.SharedCharacters.Count == 0) return;

        var random = new Random();
        var character = AppData.SharedCharacters[random.Next(AppData.SharedCharacters.Count)];

        RandomCharacterImage.Source = character.Image;
        RandomCharacterName.Text = character.Name;
    }
}
