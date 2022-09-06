namespace TicTacToe
{
    internal class Program
    {
        static char[,] gameArray = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static void Main(string[] args)
        {
            //Run Play method to start program
            Play();
        }

        static void Title()             //Main Title which will be present at top of all pages
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    Welcome to CPK's TicTacToe\n\n");
            Console.ResetColor();
        }

        static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Menu: [R] Restart   [E] End Game");
            Console.ResetColor();
        }

        static void End()               //When run this will thank the players and end the program
        {
            
            Title();
            Console.WriteLine("\n      Thank you for playing!");
            System.Environment.Exit(0);
        }

        static void Congratulations(char winner)
        {
            Title();
            GameBoard();
            Console.WriteLine("\nCongratulations we have a winner!\n\t  The {0}'s Win!!\n     Press a key to play again!", winner);
            Console.ReadKey();
            GameReset();
        }

        static void GameReset()
        {
            gameArray = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } }; Player1();
        }

        static void GameBoard()         //Our TicTacToe Gameboard displaying the array in the typical format for the game
        {
            Console.WriteLine("\t     |     |     ");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", gameArray[0,0], gameArray[0,1], gameArray[0,2]);
            Console.WriteLine("\t_____|_____|_____");
            Console.WriteLine("\t     |     |     ");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", gameArray[1,0], gameArray[1,1], gameArray[1,2]);
            Console.WriteLine("\t_____|_____|_____");
            Console.WriteLine("\t     |     |     ");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", gameArray[2,0], gameArray[2,1], gameArray[2,2]);
            Console.WriteLine("\t     |     |     ");
        }

        static void Play()              //This is where the program begins by running the Player1 method
        {
            Player1();
        }
        static void CheckGame(string player)    //This method will check whether win conditions have been met after each turn
        {
            int turns = 0;
            foreach (char c in gameArray)
            {
                if (c == 'X')
                {
                    turns++;
                }
            }
            if (turns == 5)
            {   
                Title();
                GameBoard();
                Console.WriteLine("\n\t   It's a draw!\n     Press a key to play again."); Console.ReadKey();
                GameReset();
            }
            
            if (gameArray[0,0] == gameArray[1,0] && gameArray[1,0] == gameArray[2,0])   //If we have matching characters in left column, game ends
            {
                Congratulations(gameArray[0,0]);
            }
            if (gameArray[0,1] == gameArray[1,1] && gameArray[1,1] == gameArray[2,1])   //If we have matching characters in middle column, game ends
            {
                Congratulations(gameArray[0,1]);
            }
            if (gameArray[0,2] == gameArray[1,2] && gameArray[1,2] == gameArray[2,2])   //If we have matching characters in right column, game ends
            {
                Congratulations(gameArray[0, 2]);
            }
            if (gameArray[0,0] == gameArray[1,1] && gameArray[1,1] == gameArray[2,2])   //If we have matching characters in diagonal from top left to bottom right, game ends
            {
                Congratulations(gameArray[0, 0]);
            }
            if (gameArray[0,2] == gameArray[1,1] && gameArray[1,1] == gameArray[2,0]) //If we have matching characters in diagonal from top right to bottom left, game ends
            {
                Congratulations(gameArray[0, 2]);
            }
            if (gameArray[0,0] == gameArray[0,1] && gameArray[0,1] == gameArray[0,2])   //If we have matching characters along the top row, game ends
            {
                Congratulations(gameArray[0, 0]);
            }
            if (gameArray[1,0] == gameArray[1,1] && gameArray[1,1] == gameArray[1,2])   //If we have matching characters along middle row, game ends
            {
                Congratulations(gameArray[1,0]);
            }
            if (gameArray[2,0] == gameArray[2,1] && gameArray[2,1] == gameArray[2,2])   //If we have matching characters along bottom row, game ends
            {
                Congratulations(gameArray[2,0]);
            }
            else if (player == "Player1")       //If player that brought us to this point was player 1, we move to player 2's turn
            {
                Player2();
            }
            else if (player == "Player2")       //If player that brought us to this point was player 2, we move to player 1's turn
            {
                Player1();
            }
        }

        static void Player1()
        {
            Title();
            GameBoard();
            try         //Try catch to capture invalid inputs
            {
                Console.WriteLine("\n\tPlayer 1, You are X. \n  Please choose where to place X");
                Footer();
                char input1 = Char.Parse(Console.ReadLine());
            
            switch (input1)
            {
                case '1':
                    {
                        if (gameArray[0, 0] != 'O' && gameArray[0, 0] != 'X')
                        {
                            gameArray[0, 0] = 'X';
                            CheckGame("Player1");
                        } else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '2':
                    {
                        if (gameArray[0, 1] != 'O' && gameArray[0, 1] != 'X')
                        {
                            gameArray[0, 1] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '3':
                    {
                        if (gameArray[0, 2] != 'O' && gameArray[0, 2] != 'X')
                        {
                            gameArray[0, 2] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '4':
                    {
                        if (gameArray[1, 0] != 'O' && gameArray[1, 0] != 'X')
                        {
                            gameArray[1, 0] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '5':
                    {
                        if (gameArray[1, 1] != 'O' && gameArray[1, 1] != 'X')
                        {
                            gameArray[1, 1] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '6':
                    {
                        if (gameArray[1, 2] != 'O' && gameArray[1, 2] != 'X')
                        {
                            gameArray[1, 2] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '7':
                    {
                        if (gameArray[2, 0] != 'O' && gameArray[2, 0] != 'X')
                        {
                            gameArray[2, 0] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '8':
                    {
                        if (gameArray[2, 1] != 'O' && gameArray[2, 1] != 'X')
                        {
                            gameArray[2, 1] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                case '9':
                    {
                        if (gameArray[2, 2] != 'O' && gameArray[2, 2] != 'X')
                        {
                            gameArray[2, 2] = 'X';
                            CheckGame("Player1");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player1();
                            }
                            break;
                    }
                    case 'e':
                        {
                            End();
                        }
                        break;
                    case 'r':
                        {
                            GameReset();
                        }
                        break;
                default:
                    {
                        Console.WriteLine("Sorry, you have selected an incorrect location. Please try again."); Player1();
                    }
                    break;
            }
            }
            catch { Console.WriteLine("Invalid input detected. Please correct."); Console.ReadKey(); Player1(); }
        }

        static void Player2()
        {
            Title();
            GameBoard();
            try { 
            Console.WriteLine("\n\tPlayer 2, You are O. \n  Please choose where to place O");
            Footer();
                char input2 = Char.Parse(Console.ReadLine());

            switch (input2)
            {
                case '1':
                    {
                        if (gameArray[0, 0] != 'O' && gameArray[0, 0] != 'X')
                        {
                            gameArray[0, 0] = 'O';
                            CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '2':
                        {
                            if (gameArray[0, 1] != 'O' && gameArray[0, 1] != 'X')
                            {
                                gameArray[0, 1] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '3':
                        {
                            if (gameArray[0, 2] != 'O' && gameArray[0, 2] != 'X')
                            {
                                gameArray[0, 2] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '4':
                        {
                            if (gameArray[1, 0] != 'O' && gameArray[1, 0] != 'X')
                            {
                                gameArray[1, 0] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '5':
                        {
                            if (gameArray[1, 1] != 'O' && gameArray[1, 1] != 'X')
                            {
                                gameArray[1, 1] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '6':
                        {
                            if (gameArray[1, 2] != 'O' && gameArray[1, 2] != 'X')
                            {
                                gameArray[1, 2] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '7':
                        {
                            if (gameArray[2, 0] != 'O' && gameArray[2, 0] != 'X')
                            {
                                gameArray[2, 0] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '8':
                        {
                            if (gameArray[2, 1] != 'O' && gameArray[2, 1] != 'X')
                            {
                                gameArray[2, 1] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case '9':
                        {
                            if (gameArray[2, 2] != 'O' && gameArray[2, 2] != 'X')
                            {
                                gameArray[2, 2] = 'O';
                                CheckGame("Player2");
                        }
                            else if (gameArray[0, 0] == 'O' || gameArray[0, 0] == 'X')
                            {
                                Console.WriteLine("Sorry, this field is already taken.\nPlease choose again."); ;
                                Console.ReadKey();
                                Player2();
                            }
                            break;
                        }
                    case 'e':
                        {
                            End();
                        }
                        break;
                    case 'r':
                        {
                            GameReset();
                        }
                        break;
                    default:
                    {
                        Console.WriteLine("Sorry, you have selected an incorrect location. Please try again."); Console.ReadKey(); Player2();
                    }
                    break;
            }
        }
            catch { Console.WriteLine("Invalid input detected. Please correct."); Player2();
    }
}
    }
}