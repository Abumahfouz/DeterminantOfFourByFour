namespace DeterminantOfFourByFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] fourDimArray = new int[4, 4]
           {
                {1,1,1,-1 },
                { 1,1,-1,1},
                { 1,-1,1,1},
                {-1,1,1,1 },
           };

            int cell1 = fourDimArray[0, 0];
            int cell2 = fourDimArray[0, 1];
            int cell3 = fourDimArray[0, 2];
            int cell4 = fourDimArray[0, 3];
            int cell5 = fourDimArray[1, 0];
            int cell6 = fourDimArray[1, 1];
            int cell7 = fourDimArray[1, 2];
            int cell8 = fourDimArray[1, 3];
            int cell9 = fourDimArray[2, 0];
            int cell10 = fourDimArray[2, 1];
            int cell11 = fourDimArray[2, 2];
            int cell12 = fourDimArray[2, 3];
            int cell13 = fourDimArray[3, 0];
            int cell14 = fourDimArray[3, 1];
            int cell15 = fourDimArray[3, 2];
            int cell16 = fourDimArray[3, 3];

            int detArray = cell1 * cell6 * A33 * A44 + cell1 * cell7 * A34 * A42 + cell1 * cell8 * cell10 * A43
                            - cell1 * cell8 * A33 * A42 - cell1 * cell7 * cell10 * A44 - cell1 * cell6 * A34 * A43
                            - cell2 * cell5 * A33 * A44 - cell3 * cell5 * A34 * A42 - cell4 * cell5 * cell10 * A43
                           + cell4 * cell5 * A33 * A42 + cell3 * cell5 * cell10 * A44 + cell2 * cell5 * A34 * A43
                           + cell2 * cell7 * cell9 * A44 + cell3 * cell8 * cell9 * A42 + cell4 * cell6 * cell9 * A43
                           - cell4 * cell7 * cell9 * A42 - cell3 * cell6 * cell9 * A44 - cell2 * cell8 * cell9 * A43
                           - cell2 * cell7 * A34 * A41 - cell3 * cell8 * cell10 * A41 - cell4 * cell6 * A33 * A41
                           + cell4 * cell7 * cell10 * A41 + cell3 * cell6 * A34 * A41 + cell2 * cell8 * A33 * A41;
            Console.WriteLine(detArray);
        }
    }
}
