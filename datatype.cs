using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace datatype
{
    class datatype
    {
        static void Main(string[] args)
        {
            bool testbool = true;// true와 false를 입력받는 타입

            short testshort = 3000;
            int testint = 3000;
            uint testuint= 3000U;//숫자뒤에 U를 붙여 unsigned임을 지정
            long testlong = 3000;
            ulong testulong = 3000UL;//숫자뒤에 UL를 붙여 unsigned임을 지정
            float testfloat = 3000.0003F;//F로 float임을 나타낸다, 필수임
            double testdouble = 3000.0003;
            double testdoubleD = 3000.0003D;//D로 double임을 나타낸다. 필수는 아님
            decimal testdecimal = 3000.0003M;//M으로 decimal임을 나타낸다. 필수임
            //각 타입별 suffix는 필수가 아니더라도 입력하는 데이터의 타입을 지정하는 의의가 있다.

            char testchar = 'H';//' '로 단문자를 받는다
            string teststring = "Helloworld";//" " 로 문자열을 받는다.

            int testintmax = int.MaxValue;//.MaxValue앞에 int를 붙여 int형의 최댓값을 호출
            float testfloatmin = float.MinValue;//MinValue앞에 float를 붙여 float형의 최솟값을 호출

            //NULL을 가질수 있는 타입, 없는 타입이 존재
            //Referance타입은 가질수 있다. Value타입은 가질 수 없다.
            string testnullstring;
            testnullstring = null;//문자열은 NULL타입을 가질수 있다.

            int? test_nullable_int = null;//nullable<t>로 변경
            //int는 NULL을 가질수 없지만 자료형뒤에 ?를 붙여서 NULL가질수 있게 되었다.
            //이러한 것들을 NULLable type이라고 한다.
            test_nullable_int = 3000;
            int test_int_value = test_nullable_int.Value;
            //nullable type을 다시 nullable의 .Value속성을 이용해 value type으로 변환하였다.

            object test_object_bool = true;
            object test_object_int = 3000;
            object test_object_double = 3000.0003D;
            //C++의 auto와 유사한 타입
            //그러나 object는 c#의 참조형식이나 값형식과 같은 친구들을 간접, 직접 상속하는 근본 타입이다. 


        }
    }
}
