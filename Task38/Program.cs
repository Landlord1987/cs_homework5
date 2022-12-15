int N = new Random().Next(3, 10); //Рандом расчет длины массива
double min, max;
double[] Array = InitializeRandomArray(N); //Инициализируем массив рандомными числами
double res = CalcDiffMinMax(Array, out min, out max); //Метод расчета min и max и их разницы
Console.WriteLine("Разница между max({0}) и min({1}): {2}",max, min, res);//Выводим разницу между max и min
PrintArray(Array);//Печатаем массив для проверки

//Метод печати массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write("; " + arr[i]);
    }
    Console.Write("]");
}
//Метод расчета разницы между max и min
double CalcDiffMinMax(double[] Array, out double min, out double max)
{
    min = Array[0];
    max = Array[0];
    
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < min) min = Array[i];
        if (Array[i] >= max) max = Array[i];
    }
    double res = max - min;
    return res;
}
//Инициализацияя рандомного массива
double[] InitializeRandomArray(int N)
{
    Random rnd = new Random();
    double[] arr = new double[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return arr;
}