Console.Write("Введите число обозначающее количество чисел ко вводу: ");
int length = Convert.ToInt32(Console.ReadLine());

int [] array = new int [length];

for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число под индексом " + i);
    Console.WriteLine();
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();


Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {sum}");
