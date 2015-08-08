/*Task 4. Re-factor and improve the code

    Refactor and improve the naming in the C# source project Application1.sln.
    You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesGame
{
    public class Mines
    {
        private const int FIELD_ROWS = 5;
        private const int FIELD_COLUMNS = 10;
        private const int NUMBER_OF_BOMBS = 15;
        private const int MAXPOINTS = 35;

        public class Player
        {
            private string name;
            private int points;

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }

            public Player() { }

            public Player(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        static void Main(string[] args)
        {
            string commandEntry = string.Empty;
            char[,] field = CreatePlayingField();
            char[,] bombs = placeBombs();
            int pointsCounter = 0;
            bool bombActivated = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool startGame = true;
            
            bool maxPointsReached = false;

            do
            {
                if (startGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    showField(field);
                    startGame = false;
                }
                Console.Write("Daj red i kolona : ");
                commandEntry = Console.ReadLine().Trim().ToLower();
                if (commandEntry.Length >= 3)
                {
                    if (int.TryParse(commandEntry[0].ToString(), out row) &&
                    int.TryParse(commandEntry[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1) &&
                        commandEntry[1] == ' ' && int.Parse(commandEntry[0].ToString()) < FIELD_ROWS &&
                        int.Parse(commandEntry[2].ToString()) < FIELD_COLUMNS)
                    {
                        commandEntry = "turn";
                    }
                }
                switch (commandEntry)
                {
                    case "top":
                        displayRankings(players);
                        break;
                    case "restart":
                        field = CreatePlayingField();
                        bombs = placeBombs();
                        showField(field);
                        bombActivated = false;
                        startGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                EvaluatePlayersInput(field, bombs, row, column);
                                pointsCounter++;
                            }
                            if (MAXPOINTS == pointsCounter)
                            {
                                maxPointsReached = true;
                            }
                            else
                            {
                                showField(field);
                            }
                        }
                        else
                        {
                            bombActivated = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (bombActivated)
                {
                    showField(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", pointsCounter);
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCounter);
                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < player.Points)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }
                    players.Sort((Player p1, Player p2) => p2.Name.CompareTo(p1.Name));
                    players.Sort((Player p1, Player p2) => p2.Points.CompareTo(p1.Points));
                    displayRankings(players);

                    field = CreatePlayingField();
                    bombs = placeBombs();
                    pointsCounter = 0;
                    bombActivated = false;
                    startGame = true;
                }
                if (maxPointsReached)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvori 35 kletki bez kapka kryv.");
                    showField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, pointsCounter);
                    players.Add(player);
                    displayRankings(players);
                    field = CreatePlayingField();
                    bombs = placeBombs();
                    pointsCounter = 0;
                    maxPointsReached = false;
                    startGame = true;
                }
            }
            while (commandEntry != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void displayRankings(List<Player> players)
        {
            Console.WriteLine("\nTo4KI:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, players[i].Name, players[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void EvaluatePlayersInput(
                            char[,] field, char[,] bombs, int row, int column)
        {
            char numberBombsAround = EstimateNumberBombsAroundPosition(bombs, row, column);
            bombs[row, column] = numberBombsAround;
            field[row, column] = numberBombsAround;
        }

        private static void showField(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = FIELD_ROWS;
            int boardColumns = FIELD_COLUMNS;
            char[,] board = new char[boardRows, boardColumns];
            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] placeBombs()
        {
            int rows = FIELD_ROWS;
            int columns = FIELD_COLUMNS;
            char[,] playField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < NUMBER_OF_BOMBS)
            {
                Random random = new Random();
                int bombPlace = random.Next(50);
                if (!bombs.Contains(bombPlace))
                {
                    bombs.Add(bombPlace);
                }
            }

            foreach (int bombPlace in bombs)
            {
                int col = (bombPlace / columns);
                int row = (bombPlace % columns);
                if (row == 0 && bombPlace != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                playField[col, row - 1] = '*';
            }

            return playField;
        }

        private static char EstimateNumberBombsAroundPosition(char[,] bombs, int row, int column)
        {
            int count = 0;
            int rows = bombs.GetLength(0);
            int columns = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, column] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < rows)
            {
                if (bombs[row + 1, column] == '*')
                {
                    count++;
                }
            }
            if (column - 1 >= 0)
            {
                if (bombs[row, column - 1] == '*')
                {
                    count++;
                }
            }
            if (column + 1 < columns)
            {
                if (bombs[row, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombs[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (bombs[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (bombs[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (bombs[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}