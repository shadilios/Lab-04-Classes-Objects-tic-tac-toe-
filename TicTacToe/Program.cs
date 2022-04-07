using System;

namespace TicTacToe.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

            Game game = new Game(new Player(), new Player());

            game.PlayerOne.Marker = "X";
            game.PlayerTwo.Marker = "O";

            Console.WriteLine("What is your name player one?");
            game.PlayerOne.Name = Console.ReadLine();
            if (game.PlayerOne.Name.Equals(""))
            {
                game.PlayerOne.Name = "Player One";
            }

            Console.WriteLine("What is your name player two?");
            game.PlayerTwo.Name = Console.ReadLine();
            if (game.PlayerTwo.Name.Equals(""))
            {
                game.PlayerTwo.Name = "Player Two";
            }

            game.PlayerOne.IsTurn = true;
            game.PlayerTwo.IsTurn = false;
            
            game.Winner = game.Play();
            if (game.Winner == null) 
            {
                Console.WriteLine("Draw, there is no winner!");
            }
            else 
            {
               Console.WriteLine($"{game.Winner.Name} won the game. Congratulations!"); 
            }
        }


    }
}