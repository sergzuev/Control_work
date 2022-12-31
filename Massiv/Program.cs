/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/

void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {   
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] Massiv(int size)
{
    string[] arr = new string[size];
    Console.WriteLine("Введите элементы массива: ");

    for (int i = 0; i < size; i++)
    {  
        arr[i] = Console.ReadLine();    
    }
    return arr;
}

string[] NewMassiv(string[] arr)
{
    string newmassiv = "";
    foreach (string elem in arr)
    {
        if (elem.Length <= 3)
            newmassiv += elem + " ";        
    }  
    string[] NewArr = newmassiv.Split(' ');
    return NewArr;      
}

Console.WriteLine("Введите длину массива: ");
string[] arr_1 = Massiv(int.Parse(Console.ReadLine()));
Console.WriteLine("Исходный массив: ");
Print(arr_1);
string[] new_arr = NewMassiv(arr_1);
Console.WriteLine("Полученный массив: ");
Print(new_arr);