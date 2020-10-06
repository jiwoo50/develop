using System;

namespace Enum
{
    class Program
    {
       /*
        * enum은 열거형 상수를 표현하기 위한 것이다.
        * 상수에 이름을 붙여서 의미있는 단어로 표현하는 것이다.
        * 각요소는 별도의 지정이 없다면 첫번째 요소가 0, 두번째는 1과 같은 1씩증가된 수를 받는다.
        * 사용자 지정도 가능하다.
        * enum은 클래스나 네임스페이스 내에서만 선언가능/메서드나 속성은 불가
        * 숫자형 타입과 호환가능하다. enum타입 변수를 int로 캐스팅하면 해당 숫자값을 얻는다.
        */
        enum korea
        {
            koreatech,//0
            computer,//1
            machine=5,
            art=10
        }
        /*
         * 플래그 enum
         * enum에서 각 멤버는 각 비트별로 구분되는 값을 가질수 있다.
         * 이를 표현하기 위해 enum위에 [Flags]라는 Attribute를 지정할 수있다.
         * Flags특성을 갖게되면 OR연산자로 다중값을, AND연산자로 특정 멤버를 포함하는지 알수있음
         */
        [Flags]
        enum Border
        {
            None = 0,//0000
            Top = 1,//0001
            Right = 2,//0010
            Bottom = 4,//0100
            Left = 8//1000
        }
        static void Main(string[]args)
        {
            korea usekorea; //enum타입의 변수 생성
            usekorea = korea.koreatech; //0에 해당하는 koreatech으로 초기화
            int koreaValue = (int)usekorea;//usekorea를 int로 캐스팅하여 초기화
            if (usekorea == korea.koreatech)//호환이 되므로 true이다.
            {
                Console.WriteLine("Hello Tech");
            }
            Border testflag = Border.Top | Border.Bottom;
            //0001+0100=0101=1+4=5이다
            if((testflag&Border.Top)!=0)//if(testflag.HasFlag(Border.Top))
                //0001&0001=1(true)
            {
                if(testflag.HasFlag(Border.Bottom))//if((testflag&Border.Bottom)!=0)
                    //0100&0100=1(true)
                {
                    Console.WriteLine(testflag.ToString());//Tostring 메소드로 이름을 출력한다
                }
            }
        }
    }
}
