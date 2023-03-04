//Ввести позицию элемента в двумерном массиве и вывести его значение
//или сообщить, что элемента с таким номером нет
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
float [ , ] mas = new float [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-32654, 32654);
    }
}

for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-32654, 32654);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер элемента по горизонтали в массиве:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента по вертикали в массиве:");
int number2 = Convert.ToInt32(Console.ReadLine());
int m1 = mas.GetUpperBound(0) + 1;
int n1 = mas.Length / m1;
if ((number1 > m1-1) || (number2 > n1-1))
{
    Console.WriteLine ("Элемента не существует");
}
else
{
    Console.WriteLine (mas [number1,number2]);
}
