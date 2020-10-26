using System;

namespace AnonymousType
{
    /*AnonymousType : 클래스를 미리 정의하지 않고 사용할수 있게하는 익명타입이다.
     * 형식
     * new {...}
     * new블럭안에 속성=값 할당을 하고, 각 속성/값은 콤마로 분리한다.
     * 클래스를 정의할 필요없이 Type을 간단히 임시로 만들어 사용할때 유용
     */
    class Program
    {
        static void Main(string[] args)
        {
            var v = new[] {
             new { Name="Lee", Age=33, Phone="02-111-1111" },
             new { Name="Kim", Age=25, Phone="02-222-2222" },
             new { Name="Park", Age=37, Phone="02-333-3333" },
             };

            // LINQ Select를 이용해 Name과 Age만 갖는 새 익명타입 객체들을 리턴.
            var list = v.Where(p => p.Age >= 30).Select(p => new { p.Name, p.Age });//특정 조건에 맞는 데이터를 찾음
            foreach (var a in list)
            {
                Debug.WriteLine(a.Name + a.Age);//일부 컬럼들로만 구성된 새익명타입으로 리턴
            }
            var t = new { Name = "홍길동", Age = 20 };
            string s = t.Name;//변수명.익명타입 이름으로 접근
            Console.WriteLine("Hello World!");
        }
    }
}
