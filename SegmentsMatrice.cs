using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixteenSegmentDisplay
{
    public class SegmentsMatrice
    {
        public static int[,] uMap = new[,]
        {
            { 0,   1,   1,  1,  1,  1,   0,  2,  2,  2,  2,  2,  0 },
            { 3,   4,   0,  0,  0,  0,   5,  0,  0,  0,  0,  6,  7 },
            { 3,   0,   4,  0,  0,  0,   5,  0,  0,  0,  6,  0,  7 },
            { 3,   0,   0,  4,  0,  0,   5,  0,  0,  6,  0,  0,  7 },
            { 3,   0,   0,  0,  4,  0,   5,  0,  6,  0,  0,  0,  7 },
            { 3,   0,   0,  0,  0,  4,   5,  6,  0,  0,  0,  0,  7 },
            { 0,   8,   8,  8,  8,  8,   0,  9,  9,  9,  9,  9,  0 },
            {10,   0,   0,  0,  0, 14,  16, 15,  0,  0,  0,  0, 11 },
            {10,   0,   0,  0, 14,  0,  16,  0, 15,  0,  0,  0, 11 },
            {10,   0,   0, 14,  0,  0,  16,  0,  0, 15,  0,  0, 11 },
            {10,   0,  14,  0,  0,  0,  16,  0,  0,  0, 15,  0, 11 },
            {10,  14,   0,  0,  0,  0,  16,  0,  0,  0,  0, 15, 11 },
            { 0,  12,  12, 12, 12, 12,   0, 13, 13, 13, 13, 13,  0 } 
        };

        public int[] EncodeAsSevenSegmentsVector(char c)
        {
            switch (c.ToString())
            {
                case "0":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0 };
                    }

                case "1":
                    {
                        return new int[] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
                    }

                case "2":
                    {
                        return new int[] { 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0 };
                    }

                case "3":
                    {
                        return new int[] { 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0 };
                    }

                case "4":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0 };
                    }

                case "5":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0 };
                    }

                case "6":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
                    }

                case "7":
                    {
                        return new int[] { 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
                    }

                case "8":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
                    }

                case "9":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0 };
                    }

                case "A":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
                    }

                case "B":
                    {
                        return new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
                    }

                case "C":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0 };
                    }

                case "D":
                    {
                        return new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
                    }

                case "E":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0 };
                    }

                case "F":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 };
                    }

                case "G":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 };
                    }

                case "H":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
                    }

                case "I":
                    {
                        return new int[] { 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1 };
                    }

                case "J":
                    {
                        return new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
                    }

                case "K":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
                    }

                case "L":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0 };
                    }

                case "M":
                    {
                        return new int[] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0 };
                    }

                case "N":
                    {
                        return new int[] { 0, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0 };
                    }

                case "O":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
                    }

                case "P":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 };
                    }

                case "Q":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0 };
                    }

                case "R":
                    {
                        return new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0 };
                    }

                case "S":
                    {
                        return new int[] { 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0 };
                    }

                case "T":
                    {
                        return new int[] { 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                    }
                case "U":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
                    }
                case "V":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0 };
                    }
                case "W":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0 };
                    }
                case "X":
                    {
                        return new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 };
                    }
                case "Y":
                    {
                        return new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0 };
                    }
                case "Z":
                    {
                        return new int[] { 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 };
                    }

                default:
                    {
                        return new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                    }
            }
        }
    }
}
