bool IsInputValid(int b)
{
    if (b <= 0)
        return false;
    return true;
}

double InputA(string msg)
{
    Console.Write(msg);
    double input = double.Parse(Console.ReadLine());
    return input;
}

int InputB(string msg)
{
    Console.Write(msg);
    int input = int.Parse(Console.ReadLine());
    return input;
}

double NegativeDegree(double a, int b)
{
    double P = 1 / a;

    for (int i = b; i < -1; i++)
    {
        P = P * 1 / a;
    }
    return P;
}

double Degree(double a, int b)
{
    double P = a;

    for (int i = 1; i < b; i++)
    {
        P = P * a;
    }
    return P;
}

double A = InputA("Введите A=");
int B = InputB("Введите B=");
bool IsValid = IsInputValid(B);

if (IsValid)
{
    Console.WriteLine(A + " в степени " + B + " = " + Degree(A, B));
}
else if(B == 0)
{
    Console.WriteLine(A + " в степени " + B + " = " + 1);

}
else
{
        Console.WriteLine(A + " в степени " + B + " = " + NegativeDegree(A, B));
}