class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start");

        int[] numbers = { 9, 3, 1, 7, 2, 23, 15 };

        for (int i = 0; i< numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("Please work......");

        insertionSort(numbers);
    }



    private static void insertionSort(int[] numbers)
    {
        for(int i = 1; i< numbers.Length; i++){
            int temp = numbers[i];
            int j = i - 1;

            while (j >= 0 && numbers[j] > temp)
            {
                numbers[j+1] = numbers[j];
                j--;

            } 
            numbers[j+1] = temp;
        }
    }
}
