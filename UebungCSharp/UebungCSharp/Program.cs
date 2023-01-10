using System.Security.Cryptography.X509Certificates;

class Program
{
    int a = 6;
    int b = 8;
    int c = 12;
    int d = 16;

    static void Main(string[] args)
    {
        Console.WriteLine(Summe);

    }
    public int Summe
    {
        get
        {
            int sum = a + b + c + d; ;
            return sum;
        }
    }
}