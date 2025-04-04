using System.Diagnostics;

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

        // Inform the user that the cards have been switched
        _txtGameBoard.Text = "The player's card has been switched with the house!";

    }

    private void OnPlayCards(object sender, EventArgs e)
    {

        // Play a round
        sbyte roundResult = _cardGame.PlayRound();

        // Show the results of the round
        ShowRoundResults(roundResult);

        // Disable the play and switch button and allow the user to deal another command
        _btnPlayCards.IsEnabled = false;
        _btnSwitchCards.IsEnabled = false;
        _btnDealCards.IsEnabled = true;

        // Check if the game is over
        if (_cardGame.IsOver)
        {
            // Display the winner
            ShowGameOver();
        }

    }

    private void ShowGameOver()
    {
        // Display who won the game
        if (_cardGame.PlayerWins)
        {
            _txtGameBoard.Text = "The player won the game!";
        }
        else if (_cardGame.HouseWins)
        {
            _txtGameBoard.Text = "The house won the game!";
        }
        else
        {
            _txtGameBoard.Text = "There waas a tie!";
        }

        // Disable deal and switch buttons
        _btnDealCards.IsEnabled = false;
        _btnSwitchCards.IsEnabled = false;
        _btnPlayCards.IsEnabled = true;

    }

    private void ShowRoundResults(sbyte roundResult)
    {
        // Update score board
        _txtPlayerScore.Text = _cardGame.Score.PlayerScore.ToString();
        _txtHouseScore.Text = _cardGame.Score.HouseScore.ToString();

        // Show the cards that were played
        ShowCard(_imgPlayerCard, _cardGame.PlayerCard);
        ShowCard(_imgHouseCard, _cardGame.HouseCard);

        // Check if the player won, the house won, or if there is a tie
        switch (roundResult)
        {
            case 1:
                // Player won
                _txtGameBoard.Text = "The player won this round!";
                break;
            case -1:
                // House won
                _txtGameBoard.Text = "The house won this round!";
                break;
            case 0:
                // Tie
                _txtGameBoard.Text = "It's a tie!";
                break;
            default:
                Debug.Assert(false, "What is this round result?!");
                break;
        }
    }

    private void ShowCard(Image imgControl, Card card)
    {
        // Determine the image source for player and house cards based on card value
        char suitId = card.Suit.ToString()[0];
        string fileName = $"{suitId} {card.Value.ToString("00")}.png";

        // Set the image source
        imgControl.Source = ImageSource.FromFile(fileName);
    }
}