// See https://aka.ms/new-console-template for more information
public class Card
{
        public int value;
    public Card()
    {
        Random random = new Random();
        value = random.Next(1,14);
    }
}