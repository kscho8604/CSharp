// https://www.csharpstudy.com/CSharp/CSharp-enum.aspx

class Program
{
    enum City
    {
        Seoul,   // 0
        Daejun,  // 1
        Busan = 5,  // 5
        Jeju = 10   // 10
    }

[Flags]
enum Border
{
    None = 0,
    Top = 1,
    Right = 2,
    Bottom = 4,
    Left = 8
}
    static void Main(string[] args)
    {
        CityEnum();
        FlagsEnum();
    }

    static void CityEnum()
    {
        City myCity;
        
        // enum 타입에 값을 대입하는 방법
        myCity = City.Seoul;

        // enum을 int로 변환(Casting)하는 방법. 
        // (int)를 앞에 지정.
        int cityValue = (int) myCity; 

        if (myCity == City.Seoul) // enum 값을 비교하는 방법
        {
            Console.WriteLine("Welcome to Seoul");
        }        
    }

    static void FlagsEnum()
    {
        // OR 연산자로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom;

        // & 연산자로 플래그 체크
        if ((b & Border.Top) != 0)
        {
            //HasFlag()이용 플래그 체크
            if (b.HasFlag(Border.Bottom))
            {
                // "Top, Bottom" 출력
                Console.WriteLine(b.ToString());
            }
        }
    }
}