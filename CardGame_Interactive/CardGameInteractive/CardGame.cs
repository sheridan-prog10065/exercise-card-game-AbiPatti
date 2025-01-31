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
        /// <returns> A byte </returns>
        private byte DetermineCardRank()
        {
            return 0;
        }

        private void ShowRoundResult()
        {

        }

        private void ShowGameOver()
        {

        }

    }
}
