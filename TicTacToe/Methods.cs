using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace TicTacToe
{
    public class TicTacToe
    {
        public string r1c1 { get; set; }
        public string r1c2 { get; set; }
        public string r1c3 { get; set; }
        public string r2c1 { get; set; }
        public string r2c2 { get; set; }
        public string r2c3 { get; set; }
        public string r3c1 { get; set; }
        public string r3c2 { get; set; }
        public string r3c3 { get; set; }
        public string x { get; set; }
        public string o { get; set; }
        public double xTurn { get; set; }
        public double oTurn { get; set; }
        public TicTacToe()
        {
            xTurn = 0d;
            oTurn = 0.1d;
            r1c1 = "1";
            r1c2 = "2";
            r1c3 = "3";
            r2c1 = "4";
            r2c2 = "5";
            r2c3 = "6";
            r3c1 = "7";
            r3c2 = "8";
            r3c3 = "9";
            x = "X";
            o = "O";
        }
        public string CheckWinCondition()
        {
            if ((r1c1 == x && r1c2 == x && r1c3 == x) || (r2c1 == x && r2c2 == x && r2c3 == x) || (r3c1 == x && r3c2 == x && r3c3 == x) || (r1c1 == x && r2c1 == x && r3c1 == x) || (r1c2 == x && r2c2 == x && r3c2 == x) || (r1c3 == x && r2c3 == x && r3c3 == x) || (r1c1 == x && r2c2 == x && r3c3 == x) || (r1c3 == x && r2c2 == x && r3c1 == x))
            {
                // File.ReadAllLines(@"C:\ElevenFifty Projects\ElevenFiftyProjects\DotNetProjects\TicTacToe\X.txt").ToList().ForEach(c => Console.WriteLine(c));
                Console.WriteLine("X is the winner!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return "X";
            }
            if ((r1c1 == o && r1c2 == o && r1c3 == o) || (r2c1 == o && r2c2 == o && r2c3 == o) || (r3c1 == o && r3c2 == o && r3c3 == o) || (r1c1 == o && r2c1 == o && r3c1 == o) || (r1c2 == o && r2c2 == o && r3c2 == o) || (r1c3 == o && r2c3 == o && r3c3 == o) || (r1c1 == o && r2c2 == o && r3c3 == o) || (r1c3 == o && r2c2 == o && r3c1 == o))
            {
                //File.ReadAllLines(@"C:\Users\13174\Downloads\O.txt").ToList().ForEach(c => Console.WriteLine(c));
                Console.WriteLine("O is the winner!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return "O";
            }
            return "Y";
        }
    }
}