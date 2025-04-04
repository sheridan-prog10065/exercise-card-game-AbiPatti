namespace CardGameInteractive;

/// <summary>
/// Defines the card deck
/// </summary>
public class CardDeck
{
    // The list of cards in the deck
    private List<Card> _cardList;

    // Static randomizer
    private Random s_randomizer;

    public int CardCount
    {
        get { return _cardList.Count; }
    }

    /// <summary>
    /// Constructor for CardDeck class
    /// </summary>
    public CardDeck()
    {
        _cardList = new List<Card>();
        s_randomizer = new Random();

        // Create the cards in the deck
        CreateCards();

    }

    private void CreateCards()
    {
        // For each suit
        foreach (CardSuit iSuit in Enum.GetValues(typeof(CardSuit)))
        {
            // For each card value
            for (byte iValue = 1; iValue <= 13; iValue++)
            {
                // Create a card with the given suit and value
                Card card = new Card(iValue, iSuit);

                // Add the card to the deck's card list
                _cardList.Add(card);
            }
        }

    }

    public void ShuffleCards()
    {
        // For each card in the deck
        for (int iCard = 0; iCard < _cardList.Count; iCard++) 
        {
            // Choose a random position in the card list
            int randomPosition = s_randomizer.Next(iCard, _cardList.Count);

            // Replace the current card with the card at the random position
            Card randCard = _cardList[randomPosition];
            _cardList[randomPosition] = _cardList[iCard];
            _cardList[iCard] = randCard;
        }
    }

    /// <summary>
    /// Extracts two random cards from the list of cards
    /// </summary>
    /// <param name="cardOne">First card output</param>
    /// <param name="cardTwo">Second card output</param>
    /// <returns>True if the extraction was possible</returns>
    public bool GetPairOfCards(out Card cardOne, out Card cardTwo)
    {
        // Check if there are enough cards
        if (_cardList.Count >= 2)
        {
            // Extract the first card
            int randomPosition = s_randomizer.Next(0, _cardList.Count);
            cardOne = _cardList[randomPosition];
            _cardList.RemoveAt(randomPosition);

            // Extract the second card
            randomPosition = s_randomizer.Next(0, _cardList.Count);
            cardTwo = _cardList[randomPosition];

            // Return true
            return true;
        }
        else
        {
            // The extraction was not succesful
            cardOne = null;
            cardTwo = null;
            return false;
        }
    }

    public void PrintCards()
    {

    }

    public void ExchangeCards(ref Card cardOne, ref Card cardTwo)
    {
        // Swap the cards using tuple deconstruction
        (cardOne, cardTwo) = (cardTwo, cardOne);
    }
}
