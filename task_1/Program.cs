internal class Program
{
    private static void Main(string[] args)
    {
        int[] GetArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            return array;
        }

        void PrintArray(int[] array)
        {
            Console.Write($"[{String.Join(", ", array)}]");
        }

        int CountPositiveNumbers(int[] array)
        {
            int count = 0;
            foreach (int el in array)
            {
                if (el > 0)
                    count++;
            }

            return count;
        }

        Console.Write("Введите количество элементов массива: ");
        int size = int.Parse(Console.ReadLine()!);
        int[] array = GetArray(size);
        int count = CountPositiveNumbers(array);
        PrintArray(array);
        Console.WriteLine($" -> {count}");
    }
}