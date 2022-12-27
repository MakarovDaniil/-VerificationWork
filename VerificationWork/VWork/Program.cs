
// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 

Console.WriteLine("Формирование из заданного массива строк нового с длинной строк не более 3-х символов. ");
string[] array1 = new string[10] 
{"456","Hello","World","123","1567","-2","computer science","Russia","Denmark","Kazan"};
Console.WriteLine("Заданный массив:");
PrintArray(array1);
string[] array2 = new string[NumberOfElementsForTheSecondArray(array1)];
FillingTheSecondArrayByCondition(array1, array2);
Console.WriteLine("Новый массив:");
PrintArray(array2);

int NumberOfElementsForTheSecondArray(string[]array1)
{
    int count = 0;
    for (int i=0;i<array1.Length;i++)
    {
    if(array1[i].Length <= 3)
        {
        count++;
        }
    }
    return count;
}
void FillingTheSecondArrayByCondition(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
    Console.WriteLine();
}
