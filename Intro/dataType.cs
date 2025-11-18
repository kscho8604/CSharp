namespace Intro_Ex2
{    
     class Program
    {
        static void Main(string[] args)
        {
// Bool
            bool b = true;

            // Numeric
            short sh = -32768;   
            int i = 2147483647;  
            long l = 1234L;      // L suffix
            float f = 123.45F;   // F suffix
            double d1 = 123.45; 
            double d2 = 123.45D; // D suffix
            decimal d = 123.45M; // M suffix

            Console.WriteLine("decimal d: {0}", d);
            // Char/String
            char c = 'A';
            string s = "Hello";

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);
            Console.WriteLine("DateTime dt: {0}", dt);

            Nullable();
        }

        static void Nullable()
        {
            // Nullable 타입
            int? i = null;
            Console.WriteLine("i is {0}:", i ?? 0); // i is null then assign 0
            i = 101;
            Console.WriteLine("i is {0}:", i.Value);
            
            bool? b = null;

            //int? 를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
        }
    }
}