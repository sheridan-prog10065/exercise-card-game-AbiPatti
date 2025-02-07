namespace CardGameInteractive
{
    /// <summary>
    /// Defines the card deck
    /// </summary>
    public class CardDeck
    {
        // The list of cards in the deck
        private List<Card> _cardList;

        /// <summary>
        /// Constructor for CardDeck class
        /// </summary>
        public CardDeck()
        {
            _cardList = new List<Card>();
        }

        public int CardCount
        {
            get { return _cardList.Count; }
        }
    }
}
