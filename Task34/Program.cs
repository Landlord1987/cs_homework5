Console.WriteLine("массив заполненный случайными положительными трёхзначными числами!");
int N = new Random().Next(3, 10); //Рандом расчет длины массива

int[] Array = InitializeRandomArray(N); //Инициализируем массив рандомными числами
int calc = CalcOfEvenNumber(Array); //Считаем количество четных элементов массива
Console.WriteLine("В массиве четных трехзначных чисел: " + calc);//Выводим количество четных элементов в консоль
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
int CalcOfEvenNumber(int[] Array){
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if (Array[i]%2 == 0) { count++; }
    }
    return count;
}
//Инициализацияя рандомного массива
int[] InitializeRandomArray(int N){
    Random rnd = new Random();
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}