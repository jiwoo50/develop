using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    /*
     * C#에서는 정수, 구조체(int, double등), 부동자릿수는 NULL을 가질수 없다.
     * NULL할당하기 위해 필요한 방법
     * 1. 프로그램에서 사용될 것 같지 않은 특정 값을 추정하여 할당
     * 2. 또 하나의 변수를 두어 변수 i가 missing임을 나타내게 할수 있다
     * >>Nullable의 기본 아이디어
     * c#은 Valuetype이지만 null을 할당할수 있응 Nullable을 지원
     * Nullable은 Value type과 동시에 HasVAlue도 갖는 구조체이다.
     * T?==Nullable<T>
     * Nullable 구조체는 타입 캐스팅이나 암묵적 변환을 통해 Value(Non-Nullable)로 변환
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {
            int? testnull = null;
            Nullable<int> testable = null;//testnull과 testable은 같은 표현이다.
            Nullable<double> testdouble = null;
            int?[] testar = new int?[10];
        }

        double _Sum = 0;
        DateTime _Time;
        bool? _Selected ;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {

            if (i.HasValue && d.HasValue)
                this._Sum = (double)i.Value + (double)d.Value;

            // time값이 있는 체크.
            if (!time.HasValue)
                throw new ArgumentException();
            else
                this._Time = time.Value;

            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }
        /*
         * .NET Framework에 있는 정적(static) 클래스 System.Nullable에는 Nullable<t>를 위한 정적 메소드가 존재한다.
         * >> ex) Compare(), Equals(), GetUnderlyingType()
         */
        void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int result = System.Nullable.Compare<int>(a, b);
            Console.WriteLine(result); //결과 -1
            //a가 null이므로 -1이 결과로 나옴
            double? c = 0.01;
            double? d = 0.0100;
            bool result2 = System.Nullable.Equals<double>(c, d);
            Console.WriteLine(result2); //결과 true
            //대소 비교를 하는 메소드이다.
        }
    }
}
