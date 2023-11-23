using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snacke_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Program
        {
            static int width = 20;
            static int height = 10;
            static int score = 0;
            static int delay = 100;
            static bool gameOver = false;

            static int snakeX;
            static int snakeY;
            static List<int> tailX = new List<int>();
            static List<int> tailY = new List<int>();

            static int fruitX;
            static int fruitY;
            static Random random = new Random();

            static ConsoleKeyInfo keyInfo;

            static void Main(string[] args)
            {
                Setup();
                while (!gameOver)
                {
                    Draw();
                    Input();
                    Logic();
                    Thread.Sleep(delay);
                }
            }

            static void Setup()
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(width, height);
                snakeX = width / 2;
                snakeY = height / 2;
                fruitX = random.Next(0, width);
                fruitY = random.Next(0, height);
            }

            static void Draw()
            {
                Console.Clear();
                for (int i = 0; i < width + 2; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("#");
                        }
                        if (i == snakeY && j == snakeX)
                        {
                            Console.Write("O");
                        }
                        else if (i == fruitY && j == fruitX)
                        {
                            Console.Write("F");
                        }
                        else
                        {
                            bool tailPrinted = false;
                            for (int k = 0; k < tailX.Count; k++)
                            {
                                if (tailX[k] == j && tailY[k] == i)
                                {
                                    Console.Write("o");
                                    tailPrinted = true;
                                }
                            }
                            if (!tailPrinted)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (j == width - 1)
                        {
                            Console.Write("#");
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < width + 2; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                Console.WriteLine("Score: " + score);
            }

            static void Input()
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                }
            }

            static void Logic()
            {
                int prevX = tailX[0];
                int prevY = tailY[0];
                int prev2X, prev2Y;
                tailX[0] = snakeX;
                tailY[0] = snakeY;

                for (int i = 1; i < tailX.Count; i++)
                {
                    prev2X = tailX[i];
                    prev2Y = tailY[i];
                    tailX[i] = prevX;
                    tailY[i] = prevY;
                    prevX = prev2X;
                    prevY = prev2Y;
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        snakeX--;
                        break;
                    case ConsoleKey.RightArrow:
                        snakeX++;
                        break;
                    case ConsoleKey.UpArrow:
                        snakeY--;
                        break;
                    case ConsoleKey.DownArrow:
                        snakeY++;
                        break;
                }

                if (snakeX < 0 || snakeX >= width || snakeY < 0 || snakeY >= height)
                {
                    gameOver = true;
                }

                for (int i = 0; i < tailX.Count; i++)
                {
                    if (tailX[i] == snakeX && tailY[i] == snakeY)
                    {
                        gameOver = true;
                    }
                }

                if (snakeX == fruitX && snakeY == fruitY)
                {
                    score++;
                    fruitX = random.Next(0, width);
                    fruitY = random.Next(0, height);
                    tailX.Add(0);
                    tailY.Add(0);
                }
            }
        }
    }
}






