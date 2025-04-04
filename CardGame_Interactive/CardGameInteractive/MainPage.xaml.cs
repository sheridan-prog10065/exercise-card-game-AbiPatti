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
        // Make sure the cards are face down
        _imgPlayerCard.Source = s_imageSourceCardBack();
        _imgHouseCard.Source = s_imageSourceCardBack();

        // Deal cards to the player and the house
        _cardGame.DealCards();

        // Inform the user what they can do next and change usability of buttons
        _txtGameBoard.Text = "You can now play or switch cards.";

        _btnDealCards.IsEnabled = false;
        _btnSwitchCards.IsEnabled = true;
        _btnPlayCards.IsEnabled = true;

    }

    private static ImageSource s_imageSourceCardBack()
    {
        return ImageSource.FromFile("playing_card_back.jpg");
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