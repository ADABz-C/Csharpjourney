class Program
{
    public static void Main(string[] args)
    {
        //System.Console.WriteLine("Hello, World!");

        int[] nums = { 1, 5, 3, 67, 21 };

        


        int[] second = { 1, 5, 3 };
        iterate(second);
        System.Console.WriteLine();
        iterate(6, 7, 9, 54);
        System.Console.WriteLine();
        selectionSort(nums);
        iterate(nums);
    }

    private static void iterate(params int[] nums)
    {
        for(int i = 0; i< nums.Length; i++)
        {
            System.Console.Write(nums[i]+ ", ");
        }
    }

    private static void selectionSort(int[] nums)
    {
        for (int i = 0;i< nums.Length - 1 ; i++)
        {
            int min = i;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[min] > nums[j])
                {
                    min = j;
                }
            }

            int temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;

        }
    }
}