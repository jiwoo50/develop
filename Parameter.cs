using System;
using System.Diagnostics.CodeAnalysis;

namespace Parameter
{
    /*
     * C#메소드 : 클래스내에서 일련의 코드블럭을 실행시키는 함수
     *            0~n개의 인수를 갖을수 있고, 하나의 리턴값을 가짐.없다면 void로 표시
     *            접근제한자를 리턴타입 앞에 둘수 있다.
     *            ex) public int sum(int a, int b){...}
     *            메소드에 인수 전달시 값을 복사해서 전달하는 pass by value방식을 따름
     *            >>원래의 값은 변하지 않는다.
     *            메소드에 파라미터를 전달할때 파라미터명을 지정하여 파라미터를 전달할 수 있게 되었다.
     * Pass by Reference : 참조 전달
     *                     메소드에 참조 전달할 경우 C#키워드 ref를 사용
     *                     이 경우 리턴후에도 리턴값은 유효함
     *                     out키워드는 ref와 비슷하지만 변수를 초기화 할 필요가 없다.
     * Optional Parameter : 어떤 메소드의 파라미터가 디폴트 값을 갖는 경우 이 파라미터는 생략가능하다.
     *                      Optional Parameter는 반드시 파라미터들 중 맨 마지막에 놓여져야 한다.
     * params : 파라미터의 갯수를 미리 알수없는 경우 사용, 파라미터들 중 반드시 하나만 존재, 맨마지막에 위치
     * 
     */
    class Program
    {
        static int Charge(int a, int b,string charg = "-")
            //charg파라미터를 디폴트 값으로 고정함
        {
            switch (charg)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "%":
                    return a % b;
            }
            return 0;
        }
        static void squre(ref int num,out int result)
            //초기화된 main의 num의 값과 초기화되지 않은 main의 result의 값을 참조전달을 통해 변화시킴
        {
            num *= num;
            result = num;
        }
        static void sum (int num)
            //main의 num에는 아무 영향 없음
        {
            num += num;
        }
        static void Main(string[] args)
        {
            int num = 3;
            sum(num);//main num은 영향없음
            Console.WriteLine("num={0}",num);//따라서 3
            int result;
            squre(ref num, out result);//num과 result를 참조전달함
            Console.WriteLine("num={0} squre={1}", num,result);//num=9 squre=9 로 출력되어 main의 값도 변함
            Console.WriteLine("charge:{0}", Charge(3, 3));//charge:0 마지막 파라미터를 전달하지 않았음에도 정상적으로 값이 출력됨

        }
    }
}
