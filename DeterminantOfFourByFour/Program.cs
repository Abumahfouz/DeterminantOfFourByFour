namespace DeterminantOfFourByFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("The Determinant of a Four By Four Matrix!");
            int[,] fourDimensionArray = new int[4, 4]
           {
                {1,1,1,-1 },
                { 1,1,-1,1},
                { 1,-1,1,1},
                {-1,1,1,1 },
           };

            int cell1 = fourDimensionArray[0, 0];
            int cell2 = fourDimensionArray[0, 1];
            int cell3 = fourDimensionArray[0, 2];
            int cell4 = fourDimensionArray[0, 3];
            int cell5 = fourDimensionArray[1, 0];
            int cell6 = fourDimensionArray[1, 1];
            int cell7 = fourDimensionArray[1, 2];
            int cell8 = fourDimensionArray[1, 3];
            int cell9 = fourDimensionArray[2, 0];
            int cell10 = fourDimensionArray[2, 1];
            int cell11 = fourDimensionArray[2, 2];
            int cell12 = fourDimensionArray[2, 3];
            int cell13 = fourDimensionArray[3, 0];
            int cell14 = fourDimensionArray[3, 1];
            int cell15 = fourDimensionArray[3, 2];
            int cell16 = fourDimensionArray[3, 3];

            int determinant = cell1 * cell6 * cell11 * cell16 + cell1 * cell7 * cell12 * cell14 + cell1 * cell8 * cell10 * cell15
                            - cell1 * cell8 * cell11 * cell14 - cell1 * cell7 * cell10 * cell16 - cell1 * cell6 * cell12 * cell15
                            - cell2 * cell5 * cell11 * cell16 - cell3 * cell5 * cell12 * cell14 - cell4 * cell5 * cell10 * cell15
                           + cell4 * cell5 * cell11 * cell14 + cell3 * cell5 * cell10 * cell16 + cell2 * cell5 * cell12 * cell15
                           + cell2 * cell7 * cell9 * cell16 + cell3 * cell8 * cell9 * cell14 + cell4 * cell6 * cell9 * cell15
                           - cell4 * cell7 * cell9 * cell14 - cell3 * cell6 * cell9 * cell16 - cell2 * cell8 * cell9 * cell15
                           - cell2 * cell7 * cell12 * cell13 - cell3 * cell8 * cell10 * cell13 - cell4 * cell6 * cell11 * cell13
                           + cell4 * cell7 * cell10 * cell13 + cell3 * cell6 * cell12 * cell13 + cell2 * cell8 * cell11 * cell13;
            Console.WriteLine(determinant);
        }
    }
}
