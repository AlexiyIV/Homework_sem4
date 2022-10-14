double InputN(string msg)
{
    Console.Write(msg);
    double input = double.Parse(Console.ReadLine());
    return input;
}

int LenArr(double n)
{
    int la = 0;
    while (n / 10 > 0)
    {
        n = (n - n % 10) / 10;
        la++;
    }
    return la;
}

int[] FillArr(double n, int l)
{
    int[] arr = new int[l];
    for (int i = l - 1; i >= 0; i--)
    {
        arr[i] = (int)n % 10;
        n = (n - n % 10) / 10;
    }
    return arr;
}

int SumArr(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum+=arr[i];
    }
    return sum;
}

double N = InputN("input N=");
int La = LenArr(N);
//Console.WriteLine(La);
int[] Arr = FillArr(N,La);
int SumNumber = SumArr(Arr);
//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.Write(Arr[i] + ", ");
//}
Console.WriteLine(SumNumber);