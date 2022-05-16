public class Deck
{
    public Card current_card = new Card();
    public Card next_card = new Card();

    public void DealNextCard()
    {
        current_card = next_card;
        next_card = new Card();
    }
}