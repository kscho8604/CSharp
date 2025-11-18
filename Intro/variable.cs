using System;

namespace ConsoleApplication1
{
    class CSVar
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar; // field variable not assigned then default value is 0
        // 상수
        const int MAX_VALUE = 1024;
        // readonly 필드
        readonly int Max;
        public void Method1()
        {
            // 로컬변수
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar); // 0
            Console.WriteLine(localVar);  // 100
            Console.WriteLine(MAX_VALUE);  // 1024
            Console.WriteLine(Max);  // 1
        }

        public CSVar(int a)
        {
            Max = 1;
            Console.WriteLine("Constructor {0}.", a);
        }
    }

    class Program
    {
        // 모든 프로그램에는 Main()이 있어야 함.
        static void Main(string[] args)
        {
            // 테스트
            CSVar obj = new CSVar(3);
            obj.Method1();
        }
    }
}