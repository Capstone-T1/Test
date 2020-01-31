namespace Quarto_GameCore
{
    class GameManager
    {
        static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            bool exitGame = false;
            gameBoard.drawBoard();

            while (exitGame == false)
            {
                gameBoard.piecesRemaining();

                if (!gameBoard.placeGamePiece())
                    continue;

                if (gameBoard.isGameOver())
                {
                    exitGame = gameBoard.startNewGame();

                    if(exitGame)
                    {
                        gameBoard = new GameBoard();
                        gameBoard.drawBoard();
                        exitGame = false;
                    }
                }
                else
                    gameBoard.drawBoard(); 
            }
        }
    }
}