using System;

namespace Example_Generic_Delegate
{
    class Program
    {
        public delegate void MyDel<T1,T2>(T1 a , T2 b);
        public delegate T Mydelegate<T3,T>(T3 c);
        static void Main(string[] args)
        {
            MyDel<int, int> Div = div;
            Div.Invoke(100, 2);

            Mydelegate<int, string> mydelegate = PrintStr;
            mydelegate.Invoke(12);
            
        }
        public static void div(int number1 , int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine("Divid is:{0}",number1 / number2);
            }
            else
            {
                Console.WriteLine("Divid is:{0}",number2 / number1);
            }
        }
        public static string PrintStr(int a)
        {
            Console.WriteLine(a.ToString());
            return (a).ToString();
        }
    }
}
