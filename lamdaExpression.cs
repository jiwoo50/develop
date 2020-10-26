using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace lamdaExpression
{
    /*람다식 : 무명 메서드와 비슷하게 무명함수를 표현하는데 사용된다. 
     * 람다식은 입력파라미터를 =>연산자 왼쪽에, 실행문장을 =>오른쪽에 둔다.
     * 형식
     *  (입력 파라미터)=>{실행문장 블럭};
     */
    class Program
    {
        delegate int ssas(int a);
        static void Main(string[] args)
        {
            
            ssas s2 = (int c) => c + c;
            Console.WriteLine("{0}",s2(1));
            
        }
    }
}
