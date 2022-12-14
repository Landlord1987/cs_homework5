int N = new Random().Next(3, 10); //Рандом расчет длины массива

int[] Array = InitializeRandomArray(N); //Инициализируем массив рандомными числами
int sum = CalcOfOddElements(Array); //Считаем сумму нечетных элементов
Console.WriteLine("Сумма нечетных элементов массива: " + sum);//Выводим сумму нечетных элементов в консоль
PrintArray(Array);//Печатаем массив для проверки

//Метод печати массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write(", " + arr[i]);
    }
    Console.Write("]");
}
//Метод расчета количества четных элементов массива
int CalcOfOddElements(int[] Array)
{
    int sum = 0;
    for (int i = 1; i < Array.Length; i+=2)
    {
        sum += Array[i];
    }
    return sum;
}
//Инициализацияя рандомного массива
int[] InitializeRandomArray(int N)
{
    Random rnd = new Random();
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = rnd.Next(-99, 100);
    }
    return arr;
}