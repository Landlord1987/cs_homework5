int N = new Random().Next(3, 10); //Рандом расчет длины массива
int min, max;
int[] Array = InitializeRandomArray(N); //Инициализируем массив рандомными числами
int res = CalcDiffMinMax(Array, out min, out max); //Метод расчета min и max и их разницы
Console.WriteLine("Разница между max({0}) и min({1}): {2}",max, min, res);//Выводим разницу между max и min
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
//Метод расчета разницы между max и min
int CalcDiffMinMax(int[] Array, out int min, out int max)
{
    min = Array[0];
    max = Array[0];
    
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < min) min = Array[i];
        if (Array[i] >= max) max = Array[i];
    }
    int res = max - min;
    return res;
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