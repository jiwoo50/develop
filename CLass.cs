using System;

namespace TestClass
{
    /*
     * C# class는 레퍼런스 타입을 정의하는데 사용
     * 메소드 : 클래스에서 실제 행동을 일으키는 코드블럭
     * 속성 : 클래스의 내부 데이터를 외부에서 사용하게하거나, 외부에서 클래스 내부의 데이터를 간단히 설정할때
     * 필드 : 클래스의 내부 데이터는 필드에 저장. 필드들은 클래스의 객체 상태 유지에 이용해야함
     * 접근 제한자에따라 외부객체 혹은 상속객체에게 보여질 수 있다.
     * 이벤트 :  객체내부의 특정상태를 혹은 어떤일을 일어났다는 이벤트를 외부로 전달하는데 이용
     * 
     */
     public class car//모든 객체에서 접근 가능
    {
        private int testn= 3;
        //해당 클래스이외에는 접근 불가
        public int rettest()
            //다른 클래스도 접근 가능
        {
            return testn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
