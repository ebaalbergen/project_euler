using System;

namespace project_euler_493
{
    class Tester
    {
        private sbyte[] code;
        private sbyte numberOfColours;
        private int numberOfBallsPerColor;

        public Tester(int lengthOfCode, sbyte numberOfColors = 7, int numberOfBallsPerColor = 10)
        {
            code = new sbyte[lengthOfCode];
            this.numberOfColours = numberOfColors;
            this.numberOfBallsPerColor = numberOfBallsPerColor;
        }

        public Tester setCode(sbyte[] inputCode, bool overWriteLength = false)
        {
            if (inputCode.Length != code.Length)
            {
                if (!overWriteLength)
                    throw new Exception("The Length of the input and the number is not the same.");
                else
                    code = new sbyte[inputCode.Length];
            }

            code = inputCode;
            return this;
        }

        public bool testNumberPossible()
        {
            int[] balls = new int[numberOfColours];
            for (int x = 0; x < balls.Length; x++)
                balls[x] = numberOfBallsPerColor;

            foreach (sbyte ball in code)
            {
                if (balls[ball] > 0)
                    balls[ball]--;
                else
                    return false;
            }
            return true;
        }

        public int getNumberOfColours()
        {
            bool[] colorsInCode = new bool[numberOfColours];
            for (int x = 0; x < colorsInCode.Length; x++)
                colorsInCode[x] = false;

            int numberOfColoursInCode = 0;

            foreach (sbyte ball in code)
            {
                if (!colorsInCode[ball])
                {
                    colorsInCode[ball] = true;
                    numberOfColoursInCode++;
                }
            }
            return numberOfColoursInCode;
        }
    }
}
