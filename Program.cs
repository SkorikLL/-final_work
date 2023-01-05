//показывает в терминале все что входит в массив
void PrintArray (string[] nums)
{
    Console.Write("Данные которые ввел пользователь: ");
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}


void FillArray(string[] nums)
{
    int length = nums.Length;
    for (int i =0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} значение:");
        nums[i] = Convert.ToString(Console.ReadLine());
    }
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


}


Console.Clear();


//Zadacha42 ();
//Zadacha41 ();
final_work();