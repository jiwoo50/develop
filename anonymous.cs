using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AnonymousMethod
{
    /*Anonymousmethod : 메서드 명이 없는 무명 메서드
     * 어떤 메서드가 일회용으로 단순한 문장으로 구성되어 있을시
     * 굳이 별도의 메소드를 정의하지 않아도 됨
     * 형식
     * delegate(int param1) { ....};
     * 무명메서드를 사용하기위해 메서드가 필요한 곳에 직접 delegate로 시작하는 무명메서드를 써줌
     * 
     */
    public partial class Form1
    {
        public delegate int add2(int x, int y);

        public add2 add = delegate (int a, int b) { return a + b; };


    }
    class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            //form.add(1, 2);
            Console.WriteLine("{0}", form.add(1, 2));
        }
    }
}
