public class Player
{
    private int points = 300;
    private Deck deck = new Deck();

    public void PlayGame()
    {
        while (KeepPlay != "n")
        //display current card
            Console.WriteLine($"The card is: {0}" + current_card);
        //guess higher or lower
            Console.ReadLine("(H)igher or (L)ower? ");
        //display next card
            Console.WriteLine($"{0}" + next_card);
        //calculate and display new score

        //ask to play again
        
        //if points hit 0 end game
    }
}