namespace CardGameInteractive;

public partial class MainPage : ContentPage
{
    private CardGame _cardGame;

    public MainPage()
    {

        InitializeComponent();

        _cardGame = new CardGame();
    }

    private void OnDealCards(object sender, EventArgs e)
    {

        // Deal cards to the player and the house
        _cardGame.DealCards();

    }

    private void OnSwitchCards(object sender, EventArgs e)
    {

        // Switch the cards of the player with the house
        _cardGame.SwitchCards();

    }

    private void OnPlayCards(object sender, EventArgs e)
    {

        // Play a round
        _cardGame.PlayRound();

    }
}