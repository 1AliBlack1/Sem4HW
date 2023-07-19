// возведение в квадрат 

Console.WriteLine("Enter numbr A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numbr B");
int numB = Convert.ToInt32(Console.ReadLine());

void SquareAtoB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <=b ; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Result {result}");
}
SquareAtoB(numA, numB);



//Сумма цифр в числе
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

int Length(int a)
{
     int index = 0;
     while (a > 0)
    {
      a /= 10;
      index++;
    }
    return index;
}

int Sum(int a, int len)
{
   int sum = 0;
   for (int i = 1; i <= len; i++)
   {
      sum += a % 10;
      a /= 10;
   }
    return sum;
}


//Массив из 8 элементов
int[] RandomArray = new int [8];
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    RandomArray[i] = new Random().Next(0, 99);
    Console.Write(RandomArray[i] + " ");
    if(i < RandomArray.Length - 1)
        {
            Console.Write("| ");
        }
}
Console.Write("]");