using System;
using System.Security;

namespace DerivedClass
{
    /*파생클래스:기준클래스로부터 상속하여 새로운 파생클래스를 만듦
     * 상속으로 기준클래스의 데이터및 메소드를 파생클래스에서 사용가능
     * 하나의 파생클래스는 2개 이상의 기준클래스를 가질수 없다(c++과 다름)
     * 추상클래스 : 클래스명 앞에 abstract라는 키워드를 붙임 
     * 추상클래스는 객체를 직접 생성할수없다. 
     * 추상클래스 안에 클래스의 임의 멤버앞에 abstract키워드가 붙여있는 경우, 파생클래스에서 반드시 구현
     * 이때 override라는 키워드 사용
     */
     public abstract class animall
    {
        public abstract bool walk();//모든 외부에서 사용가능
        protected abstract bool hungry();//파생클래스까지 사용가능
    }
    public class dog : animall
    {
        public override bool walk()//abstract>>override를 사용해 새로 정의
        {
            return true;
        }
        protected override bool hungry()
        {
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog alice = new dog();
            animall newdog = alice as dog;
            /*as연산자 : 객체를 지정된 클래스 타입으로 변환하는데 사용
             * 성공시 해당 클래스타입으로 캐스팅, 실패시 null리턴
             */
            bool ok = alice is animall;
            //is연산자:is앞에 있는객체가 특정클래스타입이나 인터페이스를 갖고있는지 확인
             
            animall newdog2 = (animall)alice;
            //캐스팅을 사용하면 변환 실패시 Exception을 발생시키게 되는데, catch하지 않으면 프로그램중지됨
            bool ok2 = newdog2 is animall;
            Console.WriteLine("{0} {1}",ok,ok2);//true, true
        }
    }
}
