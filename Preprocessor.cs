#define TEST_ENV
using System;
//#define PROD_ENV

namespace Preprocessor
{
    /*
     * 전처리기 지시어는 실제 컴파일 시작전, 컴파일러에게 명령을 미치 처리하도록 지시하는 것
     * C#의 전처리기 지시어는 #으로 시작됨
     * 한라인에 한 개의 전처리기 명령만 사용, 세미콜론을 붙이지 않는다
     * 전처리기 지시어는 해당 파일 안에서만 효력 발생
     * 하나의 클래스가 두개의 파일에 나눠 저장되었을때 두개의 파일에서 동일한 심벌을 사용하고 싶다면 각각 심벌을 정의
     */
     /*
      * 조건별 컴파일
      * #define은 심벌을 정의 할때 사용
      * >> ex) #define DEBUG/ #define RELEASE
      * #define과 #if를 결합해 조건별로 서로 다른 코드블럭을 컴파이 할 수 있다.
      */
    class Program

    {
        static void Main(string[] args)
        {
            bool verbose = false;
            // ...

#if (TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif

            if (verbose)
            {
                //....
            }
        }
        /*
         * region 전처리기 지시어
         * #region은 코드블럭을 논리적으로묶을때 유용함
         * >>ex) public 메소드만 묶고 > [public Method]/ private 메소드 묶고 [Privates]
         * region과 #endregion은 쌍을 이루며 한 영역을 형성
         * 이 안에 다른 Nested Region을 둘 수도 있다.
         */
         
        class ClassA
        {
            #region Public Methods        
            public void Run() { }
            public void Create() { }
            #endregion

            #region Public Properties
            public int Id { get; set; }
            #endregion

            #region Privates
            private void Execute() { }
            #endregion
        }
        /*
         * #pragma 전처리기 지시어
         * 컴파일러 제작 업체가 고유하게 자신들의 것을 만들어 사용할 수 있는 지시어
         * 컴파일러 마다 지원되는 #pragma가 다름
         * MS의 C# 컴파일러는 현재 #prama warning과 #pragma checksum 2개를 지원하고 있다.
         */
         /*
          * #undef 는 #define과 반대로 지정된 심벌을 해제 할 때 사용한다.
          * #elif 는 #if와 함께 사용하여 else if를 나타낸다.
          * #line 은 거의 사용되진 않지만, 라인번호를 임의로 변경하거나 파일명을 임의로 다르게 설정할 수 있게 해준다.
          * #error 는 전처리시 Preprocessing을 중단하고 에러 메시지를 출력하게 한다.
          * #warning 은 경고 메서지를 출력하지만 Preprocessing은 계속 진행한다.
          * warning과 error는 특정 컴포넌트가 어떤 환경에서 실행되지 않아야 할 때 이를 경고나 에러를 통해 알리고자 할 때 사용될 수 있다.
          */ 
}
}
