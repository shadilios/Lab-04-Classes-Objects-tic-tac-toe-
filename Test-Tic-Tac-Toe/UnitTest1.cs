using System;
using Xunit;
using TicTacToe.Classes;

namespace Test_Tic_Tac_Toe
{
    public class UnitTest1
    {
        //check for win condition
        [Fact]
        public void TestForWinner()
        {
            Game game = new Game(new Player(), new Player());
            for (int i = 0; i < 3; i++)
            {
                game.Board.GameBoard[0, i] = "X";
            }

            Assert.True(game.CheckForWinner(game.Board));

            for (int i = 0; i < 3; i++)
            {
                game.Board.GameBoard[i, i] = "O";
            }

            Assert.True(game.CheckForWinner(game.Board));
        }

        //check if we can switch
        [Fact]
        public void TestSwitchPlayer()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game testGame = new Game(playerOne, playerTwo);

            //check if next player is playerOne on first time
            testGame.SwitchPlayer();
            Assert.Equal(playerOne, testGame.NextPlayer());

            //check if next player is playerTwo on second time
            testGame.SwitchPlayer();
            Assert.Equal(playerTwo, testGame.NextPlayer());
        }

        [Fact]
        public void TestPositions()
        {
            Position nineposition = new Position(2, 2);

            Assert.Equal(nineposition.Row, Player.PositionForNumber(9).Row);
            Assert.Equal(nineposition.Column, Player.PositionForNumber(9).Column);

        }

        [Fact]
        public void TestDisplayBoard()
        {
            //check if board is displayed properly
            Board board = new Board();

            Assert.Equal(1, Convert.ToInt32(board.GameBoard[0, 0]));
            Assert.Equal(2, Convert.ToInt32(board.GameBoard[0, 1]));
            Assert.Equal(3, Convert.ToInt32(board.GameBoard[0, 2]));
            Assert.Equal(4, Convert.ToInt32(board.GameBoard[1, 0]));
            Assert.Equal(5, Convert.ToInt32(board.GameBoard[1, 1]));
            Assert.Equal(6, Convert.ToInt32(board.GameBoard[1, 2]));
            Assert.Equal(7, Convert.ToInt32(board.GameBoard[2, 0]));
            Assert.Equal(8, Convert.ToInt32(board.GameBoard[2, 1]));
            Assert.Equal(9, Convert.ToInt32(board.GameBoard[2, 2]));
        }

    }
}
