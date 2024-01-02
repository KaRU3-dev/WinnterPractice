// Practice 04: Card Game
using CardGame;

class Program
{
    static void Main()
    {
        IPlayer player1 = new HumanPlayer();
        IPlayer player2 = new CPUPlayer();

        Game game = new Game(player1, player2);
        game.Play();
    }
}
