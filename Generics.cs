using System;

namespace Generics
{
    /*제네릭: 여러가지 데이터 타입을 파라미터로 받아야할때 사용
     * 데이터 요소타입을 확정하지 않고 이 데이터 타입자체를 타입파라미터로 받아들임
     * 제네릭 타입 제약 : 제네릭 타입을 선언할 때 타입 파라미터가 value타입인지 reference타입인지
     * 또는 어떤 특정 기준클래스로부터 파생된 타입인지 등등을 지정할수 있다
     * where T : 제약조건 의 형식으로 가능
     */
    class Mystack<T> where T:class
        //class Mystack<T> where T:class int사용 불가
        //class Mystack<T> where T:new string사용 불가
        //class Mystack<T> where T :struct string사용불가
        /*class Mystack<T, U> 
         * where T:class
         * where U:class  복수타입 파라미터 제약
         */
    {
        T[] _elements;
        int pos = 0;
        public Mystack()
        {
            _elements = new T[100];
        }
        public void Push(T element)
        {
            _elements[++pos] = element;
        }
        public T pop()
        {
            return _elements[pos--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Mystack<int> numberstack = new Mystack<int>(); 제약조건 where T:class로인해 사용 불가
            Mystack<string> namestack = new Mystack<string>();
        }
    }
}
