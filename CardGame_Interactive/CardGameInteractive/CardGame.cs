using System.Diagnostics;

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
        _cardDeck.ShuffleCards();
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
    public sbyte PlayRound()
    {
        // Determine the card ranks for both the house and the player
        byte houseRank = DetermineCardRank(_houseCard);
        byte playerRank = DetermineCardRank(_playerCard);

        // Check which card has a higher rank to determine the winner
        if (playerRank > houseRank)
        {
            // The player has a higher rank
            return 1;
        }
        else if (playerRank < houseRank)
        {
            // The player has a lower rank
            return -1;
        }
        else
        {
            // There was a tie
            return 0;
        }

    }

    /// <summary>
    /// Method to deal cards to the player and house when a new game starts
    /// </summary>
    public void DealCards()
    {
        // Extract two cards, assign one to player and one to house
        bool cardsDealt = _cardDeck.GetPairOfCards(out _playerCard, out _houseCard);
        Debug.Assert(cardsDealt, "Cards could not be dealt. Check if game is over");
    }

    /// <summary>
    /// Method to switch player's cards with the house 
    /// </summary>
    public void SwitchCards()
    {

    }

    /// <summary>
    /// Method to determine the rank of card
    /// </summary>
    /// <returns> A byte that is the rank of the card</returns>
    private byte DetermineCardRank(Card card)
    {
        // Determine if card is an ace
        return (byte)((card.Value == 1) ? 14 : card.Value);
    }

    private void ShowRoundResult()
    {

    }

    private void ShowGameOver()
    {

    }

    #endregion

}