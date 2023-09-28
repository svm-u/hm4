/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Console.Clear();
int powerAB(int A, int B)
{
    int result=1;
    for (int i=1; i<=B; i++){
        result*=A;
    }
    return result;
}
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = powerAB(A, B);
Console.WriteLine(result);
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Clear();
void sum(int n, ref int result)
{
    while (n > 0)
    {
        int a =n%10;
        n /= 10;
        result+=a;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result=0;
sum(n, ref result);
Console.WriteLine(result);
*/
/*
Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];
Console.WriteLine("Введите числа для заполнения в массив: ");
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");
*/

