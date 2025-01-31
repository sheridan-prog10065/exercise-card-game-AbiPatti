namespace CardGameInteractive
{
    /// <summary>
    /// Defines the card game that implements the game logic and holds the card deck
    /// </summary>
    public class CardGame
    {
        // Represents the deck of cards the game is using
        private CardDeck _cardDeck;

        // To keep track of the score of the game
        private Score _score;

        // The card that was last played by user
        private Card _playerCard;

        // The card that was last played by house
        private Card _houseCard;

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

    }
}
