using System.Diagnostics;

namespace CardGameInteractive;

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

    public byte Value
    {
        get { return _value; }
    }

    public CardSuit Suit
    {
        get { return _suit; }
        set { _suit = value; }
    }

    public string CardName
    {
        get
        {
            switch (_value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return _value.ToString();
            }
        }
    }

    public string SuitName
    {
        get
        {
            switch (_suit)
            {
                case CardSuit.Clubs:
                    return "Clubs";
                case CardSuit.Diamonds:
                    return "Diamonds";
                case CardSuit.Hearts:
                    return "Hearts";
                case CardSuit.Spades:
                    return "Spades";
                default:
                    Debug.Assert(false, "Unknown suit value...");
                    return _suit.ToString();
            }
        }
    }
}