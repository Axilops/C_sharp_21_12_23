class Program
{
        static void PrinArray(int[] myArray, int i = 5)
    {
        if (i > -1)
        {
            Console.WriteLine(myArray[i]);
            PrinArray(myArray, i - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 5, 0, 10, 34 };

        PrinArray(myArray);
    } 
}