using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixteenSegmentDisplay
{
    class DrawSegments : SegmentsMatrice
    {
        public void DrawVector(int[] segments)
        {
            Console.Write("SEGMENTS ENCODING: ");
            foreach (var s in segments)
                Console.Write(s);
            Console.WriteLine();
        }

        public void DrawSegmentsWithStars(int[] segments)
        {
            Console.WriteLine();
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    if ((uMap[i, j] == 0))
                        Console.Write(" ");
                    else if ((segments[uMap[i, j] - 1] == 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void DrawSegmentsWithStarsByRows(int[] segments, int row)
        {
            for (int j = 0; j <= 12; j++)
            {
                if ((uMap[row, j] == 0))
                    Console.Write(" ");
                else if ((segments[uMap[row, j] - 1] == 1))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
        }

        public bool IsAllowedCharacter(char c)
        {
            switch (c.ToString())
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "A":
                case "B":
                case "C":
                case "D":
                case "E":
                case "F":
                case "G":
                case "H":
                case "I":
                case "J":
                case "K":
                case "L":
                case "M":
                case "N":
                case "O":
                case "P":
                case "Q":
                case "R":
                case "S":
                case "T":
                case "U":
                case "V":
                case "W":
                case "X":
                case "Y":
                case "Z":
                    {
                        return true;
                    }

                default:
                    {
                        return false;
                    }
            }
        }

        public void SymbolsDrawOneByOne()
        {
            string txt;
            int[] segments;

            Console.WriteLine("Enter a text:");
            Console.WriteLine("(Printable characters: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ):");
            txt = Console.ReadLine();

            foreach (var c in txt.AsEnumerable())
            {
                if ((IsAllowedCharacter(c)))
                {
                    segments = EncodeAsSevenSegmentsVector(c);
                    DrawVector(segments);
                    DrawSegmentsWithStars(segments);
                }
                else
                    Console.WriteLine("Error: This character is not allowed!");
            }

            Console.WriteLine();
            Console.Write("Press [Enter] to close the app");
            Console.ReadLine();
        }


        public void SymbolsDrawInLine()
        {
            string txt;
            int[] segments;

            Console.WriteLine("Enter a text:");
            Console.WriteLine("(Printable characters: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ):");
            txt = Console.ReadLine();

            Console.WriteLine();
            for (int row = 0; row <= 12; row++)
            {
                foreach (var c in txt.AsEnumerable())
                {
                    segments = EncodeAsSevenSegmentsVector(c);
                    DrawSegmentsWithStarsByRows(segments, row);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Press [Enter] to close the app");
            Console.ReadLine();
        }

    }
}
