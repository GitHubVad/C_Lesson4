// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 void Main(string[] args)
    {
        int[] arr = new int[8];

         Console.Write("Введите 8 цифр: ");

        for (int i = 0; i < arr.Length; i++)
        {
             arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Массив: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
 Main(args);
        