//показывает в терминале все что входит в массив
void PrintArray (string[] nums, string message = "Данные которые ввел пользователь: ")
{
    Console.Write(message);
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

//Вводим данные в массив
void FillArray(string[] nums)
{
    int length = nums.Length;
    for (int i =0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} значение:");
        nums[i] = Convert.ToString(Console.ReadLine());
    }
}

//В новый массив добавляем значания длина у которых менше или равна 3
void NewArrayLenghtThree(string[] nums)
{
    int length = nums.Length;
    string[] arrayNew = new string[length];
    int counter = 0;
    for (int i =0; i < length; i++)
    {
        if(nums[i].Length <= 3)
        {
            arrayNew[counter] = nums[i];
            counter++;
        }
    }
    PrintArray(arrayNew, "Данные в новом массиве ");
}


//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
void final_work ()
{
    Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.\n");
    Console.WriteLine("Сколько данных вы планируете ввестить?");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[sizeArray];
    FillArray(array);
    PrintArray(array);
    NewArrayLenghtThree(array);
}


Console.Clear();

final_work();