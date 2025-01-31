namespace CardGameInteractive
{
    /// <summary>
    /// Defines the card in the card game
    /// </summary>
    public class Card
    {
        // The value of the playing card
        private byte _value;

        // The suit of the player card
        private CardSuit _suit;

        /// <summary>
        /// Constructor for Card class
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(byte value, CardSuit suit)
        {
            _value = value;
            _suit = suit;
        }
    }
}
