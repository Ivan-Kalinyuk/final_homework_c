Console.WriteLine("Введите количество элементов в Вашем массиве:");
int N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите каждый новый элемент массива с новой строки:");
string [] array = new string [N];
for (int i = 0; i < N; i++)
{
    array[i] = Console.ReadLine();
    Console.Write("");
}
string [] array1 = new string [N];
int j = 0;
for (int i = 0; i < N; i++)
{
    if (array [i].Length <4)
    {
        array1 [j] = array [i];
        j++;
    }
}
Console.WriteLine("Вот элементы нового массива, количество символов которых менее 4:");
for (int k = 0; k < array1.Length; k++)
{
    Console.WriteLine(array1[k]);
}

