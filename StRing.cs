using System;
using System.Text;


namespace test_string
{
    class Program
    {
        /*
         * C#의 string은 .NET의 System.String 클래스와 동일하다.
         * System.String클래스의 모든 메소드와 속성을 사용할 수 있다.
         * C#의 문자열은 Immutable이다.(변경 불가)
         * s="hi"
         * s="hello"는 이름만 같은 다른 객체가 생성된것이다. 
         * 전혀다른 메모리를 같은 객체를 가르킨다.
         * string은 배열처럼 각 요소를 인덱스로 접근할 수 있다.
         *
         */
        static void Main(string[] args)
        {
            string teststr1 = "Hello";
            for(int i = 0; i < teststr1.Length; i++)//System.String의 .Length메소드 활용
            {
                Console.WriteLine("{0}: {1}", i, teststr1[i]);
                //인덱스를 활용하여 각 요소에 접근했다.
            }
            char[] charArray = teststr1.ToCharArray();//string로 선언된 문자열을 char배열로 변환했다.
            for(int i = 0; i < charArray.Length; i++)//System.Array의 Length 메소드 활용
            {
                Console.WriteLine("{0} : {1}", i, charArray[i]);
                //char문자열도 인덱스로 접근이 가능하다
            }
            char[] testchar = { 'A', 'B', 'C', 'D' };
            string chagechar = new string(testchar);//char배열로 선언된 문자열을 string으로 변환했다.
            Console.WriteLine(chagechar);
            string teststr2 = "world";
            string teststr3 = teststr1 + " " + teststr2;//두문자열을 합하여 Hello world라는 문자열이 되었다.
            Console.WriteLine("str3 : {0}", teststr3);
            char c1 = 'A';
            char c2 = (char)(c1 + 3);//A의 아스키코드 값은 97이다. 여기에 3을 더하면 D(100)이 된다.
            Console.WriteLine(c2);

            /*
             * 앞서 string은 Immutable이라고 했다.
             * 하지만 System.Text.StringBuilder클래스를 이용하면 Muatable타입으로 선언 할수 있다.
             * 별도의 메모리를 생성,소멸하지 않고 일정한 버퍼로 문자열을 갱신함
             * 문자열 갱신이 많은 곳에서 활용
             */
            StringBuilder testSB = new StringBuilder();
            for(int i=1;i<=26;i++)
            {
                testSB.Append(i.ToString());
                testSB.Append(System.Environment.NewLine);
            }
            string s = testSB.ToString();
            Console.WriteLine(s);
        }
    }
}
