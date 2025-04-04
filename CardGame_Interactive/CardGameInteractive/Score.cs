namespace CardGameInteractive;

/// <summary>
/// Defines the score in the card game
/// </summary>
public struct Score
{
    // The number of rounds won by the player
    private int _playerScore;

    // The number of rounds won by the house
    private int _houseScore;

    public int PlayerScore
    {
        get { return _playerScore; }
    } 
    public int HouseScore
    {
        get { return _houseScore; }
    }
}