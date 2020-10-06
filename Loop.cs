using System;
using System.Collections.Generic;
namespace loop
{
    /*
     * for문
     * 일정한 동작을 정해진 횟수만큼 반복하는 루프
     * foreach문
     * 배열이나 컬렉션에 사용, 각 요소를 꺼내서 블럭을 실행할때 사용
     * >> 성능차이는 크지 않음, foreach가 더 간결함, foreach는 배열 사용에 이점
     * >> 반면 for문은 사용자가 정할 수 있음, 상황에 적합한 것으로 사용
     */
     /*
      * while문
      * while조건식이 참이면 반복한다.
      * do while문
      * while문과 달리 블럭을 한번 미리 실행한다.
      */
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("loop {0}", i);
            }
            string[] array = new string[] { "AB", "CD", "EF" };

            foreach(string s in array)
            {
                Console.WriteLine(s);
            }
            //예제 코드
            List<char> keyList = new List<char>();//char타입의 list생성
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();//입력을 받음
                keyList.Add(key.KeyChar);//list에 저장
            } while (key.Key != ConsoleKey.Q); // Q가 아니면 계속

            Console.WriteLine();
            foreach (char ch in keyList) // 리스트 루프
            {
                Console.Write(ch);//리스트의 수만큼 리스트내의 요소들을 출력한다.
            }
        }
    }
}
