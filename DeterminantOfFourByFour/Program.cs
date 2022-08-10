namespace DeterminantOfFourByFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Determinant of a Four By Four Matrix!");
            int[,] D = new int[4, 4]
           {
                {1,1,1,-1 },
                { 1,1,-1,1},
                { 1,-1,1,1},
                {-1,1,1,1 },
           };
            



            int determinant = D[0, 0] * (D[1, 1] * ((D[2, 2] * D[3, 3]) - (D[3, 2] * D[2, 3])) - D[1, 2] * ((D[2, 1] * D[3, 3]) - (D[3, 1] * D[2, 3])) + D[1, 3] * ((D[2, 1] * D[3, 2]) - (D[3, 1] * D[2, 2])))
                            - D[0, 1] * (D[1, 0] * ((D[2, 2] * D[3, 3]) - (D[3, 2] * D[2, 3])) - D[1, 2] * ((D[2, 0] * D[3, 3]) - (D[3, 0] * D[2, 3])) + D[1, 3] * ((D[2, 0] * D[3, 2]) - (D[3, 0] * D[2, 2])))
                            + D[0, 2] * (D[1, 0] * ((D[2, 1] * D[3, 3]) - (D[3, 1] * D[2, 3])) - D[1, 1] * ((D[2, 0] * D[3, 3]) - (D[3, 0] * D[2, 3])) + D[1, 3] * ((D[2, 0] * D[3, 1]) - (D[3, 0] * D[2, 1])))
                            - D[0, 3] * (D[1, 0] * ((D[2, 1] * D[3, 2]) - (D[3, 1] * D[2, 2])) - D[1, 1] * ((D[2, 0] * D[3, 2]) - (D[3, 0] * D[2, 2])) + D[1, 2] * ((D[2, 0] * D[3, 1]) - (D[3, 0] * D[2, 1])));
            Console.WriteLine("\n");
            Console.WriteLine("\n The determinant is " + determinant);
        }
    }
}
