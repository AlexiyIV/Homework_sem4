int InputData(string msg)
{
    Console.Write(msg);
    int input = int.Parse(Console.ReadLine());
    return input;
}



int[] FillArr(int l, int min, int max)
{
    int[] arr = new int[l];
    for (int i = 0; i < l; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


void OutArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length-1] + "]");
}


int N = InputData("Введите длинну массива N=");
int Min = InputData("Введите минимальное значение элемента Min=");
int Max = InputData("Введите максимальное значение элемента Max=");
if (Min >= Max )
{
    Console.WriteLine("не корректное значение минимума и максимума");
}
else
{
    int[] Arr = FillArr(N, Min, Max);

    OutArr(Arr);
}

