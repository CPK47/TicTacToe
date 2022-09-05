namespace TicTacToe
{
    internal class Program
    {
        static char[,] gameArray = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static void Main(string[] args)
        {
            Play();
        }

        static void Title()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    Welcome to CPK's TicTacToe\n\n");
            Console.ResetColor();
        }

        static void End()
        {
            
            Title();
            Console.WriteLine("\n      Thank you for playing!");
            System.Environment.Exit(0);
        }

        static void GameBoard()
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

        static void Play()
        {
            Player1();
        }
        static void CheckGame(string player)
        {
            if (gameArray[0,0] == gameArray[1,0] && gameArray[1,0] == gameArray[2,0])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0,0]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[0,1] == gameArray[1,1] && gameArray[1,1] == gameArray[2,1])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0, 1]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[0, 2] == gameArray[1, 2] && gameArray[1, 2] == gameArray[2, 2])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0, 2]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[0,0] == gameArray[1,1] && gameArray[1,1] == gameArray[2,2])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0,0]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[0,2] == gameArray[1, 1] && gameArray[1, 1] == gameArray[2,0])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0, 2]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[0,0] == gameArray[0,1] && gameArray[0,1] == gameArray[0,2])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[0,0]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[1, 0] == gameArray[1, 1] && gameArray[1, 1] == gameArray[1, 2])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[1, 0]);
                Console.ReadKey();
                End();
                
            }
            if (gameArray[2, 0] == gameArray[2, 1] && gameArray[2, 1] == gameArray[2, 2])
            {
                Title();
                GameBoard();
                Console.WriteLine("Congratulations we have a winner! The {0}'s Win!!", gameArray[2, 0]);
                Console.ReadKey();
                End();
            }
            else if (player == "Player1")
            {
                Player2();
            }
            else if (player == "Player2")
            {
                Player1();
            }
        }

        static void Player1()
        {
            Title();
            GameBoard();
            try
            {
                Console.WriteLine("Player 1, You are X. Please choice your location to place an X: ");
                char input1 = Char.Parse(Console.ReadLine());
            
            switch (input1)
            {
                case '1':
                    {
                        if (gameArray[0, 0] != 'O' && gameArray[0, 0] != 'X')
                        {
                            gameArray[0, 0] = 'X';
                            CheckGame("Player1");
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
                        break;
                    }
                case '3':
                    {
                        if (gameArray[0, 2] != 'O' && gameArray[0, 2] != 'X')
                        {
                            gameArray[0, 2] = 'X';
                            CheckGame("Player1");
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
                        break;
                    }
                case '5':
                    {
                        if (gameArray[1, 1] != 'O' && gameArray[1, 1] != 'X')
                        {
                            gameArray[1, 1] = 'X';
                            CheckGame("Player1");
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
                        break;
                    }
                case '7':
                    {
                        if (gameArray[2, 0] != 'O' && gameArray[2, 0] != 'X')
                        {
                            gameArray[2, 0] = 'X';
                            CheckGame("Player1");
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
                        break;
                    }
                case '9':
                    {
                        if (gameArray[2, 2] != 'O' && gameArray[2, 2] != 'X')
                        {
                            gameArray[2, 2] = 'X';
                            CheckGame("Player1");
                        }
                        break;
                    }
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
            Console.WriteLine("Player 2, You are O. Please choice your location to place an O: ");
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
                        break;
                        }
                    case '2':
                        {
                            if (gameArray[0, 1] != 'O' && gameArray[0, 1] != 'X')
                            {
                                gameArray[0, 1] = 'O';
                                CheckGame("Player2");
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
                            break;
                        }
                    case '4':
                        {
                            if (gameArray[1, 0] != 'O' && gameArray[1, 0] != 'X')
                            {
                                gameArray[1, 0] = 'O';
                                CheckGame("Player2");
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
                            break;
                        }
                    case '6':
                        {
                            if (gameArray[1, 2] != 'O' && gameArray[1, 2] != 'X')
                            {
                                gameArray[1, 2] = 'O';
                                CheckGame("Player2");
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
                            break;
                        }
                    case '8':
                        {
                            if (gameArray[2, 1] != 'O' && gameArray[2, 1] != 'X')
                            {
                                gameArray[2, 1] = 'O';
                                CheckGame("Player2");
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
                            break;
                        }
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