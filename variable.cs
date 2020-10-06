using System;
using System.ComponentModel.DataAnnotations;

namespace variable
{
    class CSVar
    {
        int globalvariable;//초기화를 없으므로 0으로 할당
        const int MAX_VALUE = 1024;
        //const키워드는 해당 변수가 상수임을 나타냄.
        //상수는 초기값을 변경할 수 없다.컴파일시 상수값이 결정된다

        readonly int MAX=0;
        //읽기 전용 필드이다. 필드 선언부나 클래스 생성자에서 그값을 지정할수 있다.
        //런타임시 값이 결정
        public CSVar()
        {
            Console.WriteLine(MAX);//0이 출력
            MAX = 1;
            Console.WriteLine(MAX);//1이 출력
            MAX = 2;
            Console.WriteLine(MAX);//2가 출력
        }
        public void Method1()
        {
            //MAX=3; //Method1은 생성자가 아니므로 값을 지정할 수 없다.

            int localvariable;
            localvariable = 100;
            //초기화 하지 않을 경우 다음과 같은 오류 발생
            //오류 CS0165  할당되지 않은 'localvariable' 지역 변수를 사용했습니다.
            Console.WriteLine(globalvariable);
            //0으로 출력
            Console.WriteLine(localvariable);
            //100으로 출력
            
        }
    }
    class Program
    {/*
      * 변수는 로컬변수, 전역 변수(field라 부름)로 선언될 수 있다.
      * 변수 명에서 대소문자는 구분된다 var!=Var
      * 로컬 변수 : 변수가 존재하는 메소드 안에서 만 사용
      *             메소드가 끝나면 소멸
      *             사용전 값을 반드시 할당
      * 전역 변수 : 해당 클래스의 객체가 살아있는한 계속 존속
      *             서로 다른 메소드들에서 참조할 수 있다.
      *             필드가 정적 필드이면 클래스가 처음 로드될 때 
      *             해당 타입 객체에 생성되어 프로그램이 종료될때까지 유지
      *             초기값을 할당하지 않으면 해당 타입의 기본값이 자동으로 할당
      *             ex)int의 경우 0
      */
        static void Main(string[] args)
        {

            CSVar obj = new CSVar();
            obj.Method1();
            
        }
    }
}
