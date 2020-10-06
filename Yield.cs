using System;
using System.Collections;
using System.Collections.Generic;

namespace yield
{
    /*
     * yield 키워드는 호출자에게 컬렉션 데이터를 하나씩 리턴할때 사용한다.
     * yield return : 컬렉션 데이터를 하나씩 리턴
     * yield break : 리턴을 중지하고 반복 루프를 빠져나올때 사용
     */
    class Program
    {
        //private int[] data = { 1, 2, 3 };
        static IEnumerable<int> GetNumber()
        {
            yield return 10;//----1
            yield return 20;//----2
            yield return 30;//----3
            /*순서
             * main에서 호출하면 1을 반환 후 1의 위치를 기억
             * 다시 호출시 기억한위치의 다음인 2를 반환
             * 이것을 마지막 반환값까지 반복한다.
             */
        }
        static void Main(string[] args)
        {
            foreach (var num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
