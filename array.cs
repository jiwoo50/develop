using System;
using System.Diagnostics.CodeAnalysis;

namespace array
{
    /*
     * C#에서 배열은 첫번째요소가 인덱스 0을 갖고 그뒤로 순차적으로 증가한다.
     * [ ]에 인덱스를 넣어 표기한다.
     * C#에서는 1차, 2차 ... 32차 배열 등 최고 32차 배열을 갖는다.
     * 다차원 배열(2차이상의 배열)
     * Rectangular 배열 : 요소크기가 고정된 배열
     * 가변 배열 : 첫번째 차원은 컴파일 타임에 확정
     *             두번째 이상의 차원은 각차원마다 서로 다른 크기로 지정할 수 있다.
     *             Rectangular 배열 사용시 메모리 낭비가 심한 경우 유용함
     * 2차 이상의 다차원 배열은 요소 크기가 고정된 Rectangular 배열과
     * 각차원별 크기가 다른 가변배열로 분류
     */
    class Program
    {
        static int calculatesum(int[] scores)
        {
            int sum = 0;
            for(int i = 0; i < scores.Length; i++)//.Length는 System.Array에 정의된 속성
            {
                //C#배열은 .net 프레임워크의 system.Array에서 파생
                //System.Array의 메소드, 프로퍼티를 사용할 수 있음
                sum += scores[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] teststring = { "컴공", "산경", "건공" };//[3]의 배열
            string[,] teststringREC = { { "추석", "설날" }, { "어린이날", "성탄절" } };//[2][2]사이즈의 배열

            int[][] testjagged = new int[3][];
            testjagged[0] = new int[2];
            testjagged[1] = new int[3] { 1, 2, 3 };
            testjagged[2] = new int[4] { 1, 2, 3, 4 };
            //각 일차원 마다 다른 크기의 2차원 배열을 지정했다

            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(calculatesum(scores));//배열의 전달은 배열명을 전달하고 동일한 타입의 배열로 받는다.
            //배열은 다른 객체나 메소드에 전달할때 참조값을 전달한다=>배열은 레퍼런스 타입이기 때문
        }
    }
}
