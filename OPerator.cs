using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int? j = null;
            i = j ?? 0;//i=j가 null이면 0을 반환
            //if(j==null) return 0;
            //i=null이다.
            Console.WriteLine("{0}", i);

            string t = "t";
            string s = null;
            t = s ?? string.Empty;//t=s가 null이면 빈문자열이 된다
            //if(s==null) return t=string.Empty;
            Console.WriteLine("{0}", t) ;
        }
    }
}
