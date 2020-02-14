using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace TicTacToe
{
 public class ProgramUI
    {
        string userInput;
        bool continueToRun = true;
        string endInput;
        bool endGame = true;
        public void Run()
        { RunMenu(); }
        public void RunMenu()
        {
            while (endGame)
            {
                TicTacToe tictactoe = new TicTacToe();
                while (continueToRun)
                {
                    //File.ReadAllLines(@"C:\Users\konra\OneDrive\Documents\ElevenFiftyProjects\GoldBadge\TicTacToe\TicTacToe\tictactoe.txt").ToList().ForEach(c => Console.WriteLine(c));
                    if (tictactoe.xTurn < tictactoe.oTurn)
                    { Console.WriteLine("X it's your turn!"); }
                    else
                    { Console.WriteLine("O, it's your turn!"); }
                    string topRow = String.Format("   _{0}_|_{1}_|_{2}_", tictactoe.r1c1, tictactoe.r1c2, tictactoe.r1c3);
                    string middleRow = String.Format("   _{0}_|_{1}_|_{2}_", tictactoe.r2c1, tictactoe.r2c2, tictactoe.r2c3);
                    string bottomRow = String.Format("    {0} | {1} | {2} ", tictactoe.r3c1, tictactoe.r3c2, tictactoe.r3c3);
                    Console.WriteLine(topRow);
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine(middleRow);
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine(bottomRow);
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("Enter the number of the square you'd like to claim:");
                    userInput = (Console.ReadLine()).Trim();
                    userInput.Trim();
                    if (tictactoe.xTurn < tictactoe.oTurn)
                    {
                        switch (userInput)
                        {
                            case "1":
                                if (tictactoe.r1c1 == "O" || "X" == tictactoe.r1c1)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r1c1 = "X"; }
                                break;
                            case "2":
                                if (tictactoe.r1c2 == "O" || "X" == tictactoe.r1c2)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r1c2 = "X"; }
                                break;
                            case "3":
                                if (tictactoe.r1c3 == "O" || "X" == tictactoe.r1c3)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r1c3 = "X"; }
                                break;
                            case "4":
                                if (tictactoe.r2c1 == "O" || "X" == tictactoe.r2c1)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r2c1 = "X"; }
                                break;
                            case "5":
                                if (tictactoe.r2c2 == "O" || "X" == tictactoe.r2c2)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r2c2 = "X"; }
                                break;
                            case "6":
                                if (tictactoe.r2c3 == "O" || "X" == tictactoe.r2c3)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r2c3 = "X"; }
                                break;
                            case "7":
                                if (tictactoe.r3c1 == "O" || "X" == tictactoe.r3c1)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r3c1 = "X"; }
                                break;
                            case "8":
                                if (tictactoe.r3c2 == "O" || "X" == tictactoe.r3c2)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r3c2 = "X"; }
                                break;
                            case "9":
                                if (tictactoe.r3c3 == "O" || "X" == tictactoe.r3c3)
                                { tictactoe.xTurn--; break; }
                                else
                                { tictactoe.r3c3 = "X"; }
                                break;
                            default:
                                tictactoe.xTurn--;
                                break;
                        }
                        tictactoe.xTurn++;
                    }
                    else
                    {
                        switch (userInput)
                        {
                            case "1":
                                if (tictactoe.r1c1 == "X" || "O" == tictactoe.r1c1)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r1c1 = "O"; }
                                break;
                            case "2":
                                if (tictactoe.r1c2 == "X" || "O" == tictactoe.r1c2)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r1c2 = "O"; }
                                break;
                            case "3":
                                if (tictactoe.r1c3 == "X" || "O" == tictactoe.r1c3)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r1c3 = "O"; }
                                break;
                            case "4":
                                if (tictactoe.r2c1 == "X" || "O" == tictactoe.r2c1)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r2c1 = "O"; }
                                break;
                            case "5":
                                if (tictactoe.r2c2 == "X" || "O" == tictactoe.r2c2)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r2c2 = "O"; }
                                break;
                            case "6":
                                if (tictactoe.r2c3 == "X" || "O" == tictactoe.r2c3)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r2c3 = "O"; }
                                break;
                            case "7":
                                if (tictactoe.r3c1 == "X" || "O" == tictactoe.r3c1)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r3c1 = "O"; }
                                break;
                            case "8":
                                if (tictactoe.r3c2 == "X" || "O" == tictactoe.r3c2)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r3c2 = "O"; }
                                break;
                            case "9":
                                if (tictactoe.r3c3 == "X" || "O" == tictactoe.r3c3)
                                { tictactoe.oTurn--; break; }
                                else
                                { tictactoe.r3c3 = "O"; }
                                break;
                            default:
                                tictactoe.oTurn--;
                                break;
                        }
                        tictactoe.oTurn++;
                    }
                    Console.Clear();
                    string winner = tictactoe.CheckWinCondition();
                    if (winner == "X" || winner == "O")
                    {
                        continueToRun = false;
                        break;
                    }
                    else if (tictactoe.xTurn == 5 && tictactoe.oTurn == 4.1)
                    {
                        Console.WriteLine("We have a draw");
                        break;
                    }
                    continue;
                }
                //File.ReadAllLines(@"C:\Users\13174\Downloads\tictactoe.txt").ToList().ForEach(c => Console.WriteLine(c));
                Console.WriteLine("Would you like to play again?\n" +
                    "\n" +
                    "\n" +
                    "1. Play Again\n" +
                    "2. Exit");
                endInput = (Console.ReadLine()).Trim();
                switch (endInput)
                {
                    case "1":
                        continueToRun = true;
                        Console.Clear();
                        continue;
                    case "2":
                        endGame = false;
                        break;
                }
            }
        }
    }
}
