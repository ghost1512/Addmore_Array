class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap cac phan tu vao mang");
        int[,] myArray = new int[5, 5];
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
                myArray[row, col] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            Console.WriteLine(" ");
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
                Console.WriteLine(myArray[row, col] + "," + "/n");
            }
        }
        int maxValue = 0;
        int sum = 0;
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
                sum += myArray[row, col];
                if (maxValue < myArray[row, col])
                {
                    maxValue = myArray[row, col];
                }
            }
        }
        Console.WriteLine($"Gia tri lon nhat cua mang: {maxValue}");
        Console.WriteLine($"Gia tri tong la: {sum}");
    }
}