// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
//Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов массива данных: ");
int elementCount = int.Parse(Console.ReadLine());

//массив
int[] myArray = new int[elementCount];

//метод заполнения
Random rand = new Random();

//заполнение массива через цикл
for (int i = 0; i < myArray.Length; i++)
{
    
    myArray[i] = rand.Next(0, 10);
    Console.Write("{0} ", myArray[i]);
}

//Вывод массива
Console.WriteLine();
Console.Write("Вывод массива: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + "," + " ");
}





//Console.ReadLine();

// Console.Write("Введите число элементов массива: ");
// int N = int.Parse(Console.ReadLine());

// int[] array = new int[N.Next(1,10)]; //массив  
// Random rand = new Random(); //заполняются случайными числами 

// //                     // int[] array = new int[rand.Next(1,10)];
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rand.Next(0, 2);
// }

// Console.WriteLine($"{0}", array[i]);

// int[] array = new int[rand.Next(1,10)]; //массив  
// Random rand = new Random(); //заполняются случайными числами 

//                     // int[] array = new int[rand.Next(1,10)];
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rand.Next(0, 2);
// }

// Console.WriteLine($"{0}", array[i]);


// int[] arr = new int[N]; //вводим массив, описываем что у него введено цифр пользователем 
// int[] PrintArray(int[] array); // метод ввода,который принимает аргумент массива типом int и выводит значения массив типа int
// Int count = array.Length; //длина массива
// for (int i = 0; i < count; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i]);
// }
//  return Array;
// PrintArray(arr);