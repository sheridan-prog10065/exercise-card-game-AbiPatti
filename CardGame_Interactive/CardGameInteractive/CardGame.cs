namespace CardGameInteractive;

/// <summary>
/// Defines the card game that implements the game logic and holds the card deck
/// </summary>
public class CardGame
{
    #region Fields

    // Represents the deck of cards the game is using
    private CardDeck _cardDeck;

    // To keep track of the score of the game
    private Score _score;

    // The card that was last played by user
    private Card _playerCard;

    // The card that was last played by house
    private Card _houseCard;

    #endregion

    #region Constructors

    /// <summary>
    /// The constructor of the CardGame class
    /// </summary>
    public CardGame()
    {
        _cardDeck = new CardDeck();
        _score = new Score();
        _playerCard = null;
        _houseCard = null;
    }

    #endregion

    #region Properties

    public Score Score
    {
        get { return _score; }
        set { _score = value; }
    }

    public Card PlayerCard
    {
        get { return _playerCard; }
    }

    public Card HouseCard
    {
        get { return _houseCard; }
    }

    public bool IsOver
    {
        get { return _cardDeck.CardCount < 2; }
    }

    public bool PlayerWins
    {
        get { return this.IsOver && (_score.PlayerScore > _score.HouseScore); }
    }

    public bool HouseWins
    {
        get { return this.IsOver && (_score.HouseScore > _score.PlayerScore); }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Method to play the game
    /// </summary>
    public void Play()
    {
        //TODO: Implement Play

    }

    /// <summary>
    /// Method to play a round of the game
    /// </summary>
    /// <returns>
    ///     +1: The user won the round
    ///      0: There was a tie
    ///     -1: The house won the round
    /// </returns>
    private sbyte PlayRound()
    {
        //TODO: Implement this method
        return 0;
    }

    /// <summary>
    /// Method to deal cards to the player and house when a new house starts
    /// </summary>
    private void DealCards()
    {

    }

    /// <summary>
    /// Method to switch player's cards with the house 
    /// </summary>
    private void SwitchCards()
    {

    }

    /// <summary>
    /// Method to determine the rank of card
    /// </summary>
    /// <returns> A byte that is the rank of the card</returns>
    private byte DetermineCardRank(Card card)
    {
        // Check if card is an ace
        if (card.Value == 1)
        {
            return 14;
        }
        else
        {
            return card.Value;
        }
    }

    private void ShowRoundResult()
    {

    }

    private void ShowGameOver()
    {

    }

    #endregion

}