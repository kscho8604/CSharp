//https://www.csharpstudy.com/CSharp/CSharp-operator.aspx

class Program
{
    static void Main(string[] args)
    {
        Null_coalescing_operator();        
    }

    static void Null_coalescing_operator()
    {
        int? i = null;
        i = i ?? 0;
        Console.WriteLine("i is {0}",i);
        
        int? i2 = null;
        i2 ??= int.MaxValue;
        Console.WriteLine("i2 is {0}",i2);
        
        string s = null;
        s = s ?? string.Empty;
        Console.WriteLine("s is {0}", s);

        string s2 = null;
        s2 = s2 ?? "Empty";
        Console.WriteLine("s2 is {0}", s2);        
    }
}