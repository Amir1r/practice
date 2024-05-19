using System;

namespace fibonacci
{
    class program
    {
        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i + + )
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void main()
        {
            for (int i = 0; i < 15; i++)
        {
    
    console.writeline(fibonacci(i))               
            }
            concole.readline();
        }
    }
}
