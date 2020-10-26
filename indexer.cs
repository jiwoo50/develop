using System;

namespace ConsoleApp7
{
    /*
     * indexer
     * 클래스 객체의 데이터를 배열형태로 인덱스를 써서 엑세스 할수 있게 함
     * this[]를 사용해 get과 set을 정의
     * 리턴 데이터 타입도 여러가지로 지정
     * 인덱스에는 주로int나 string타입이 사용됨
     */
    class Myclass
    {
        private const int MAX = 10;
        private string name;
        //내부의 정수 배열 데이터
        private int[] data = new int[MAX];//사이즈 10의배열
        //인덱서 정의, int파라미터 사용
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)//0미만 10이상이면
                {
                    throw new IndexOutOfRangeException();//out of range
                }
                else
                {
                    return data[index];//0이상 10미만이면 값 리턴
                }
            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    data[index] = value;//인덱스별로 데이터를 넣음
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass cls = new Myclass();
            //인덱서 set사용
            cls[1] = 1024;
            //인덱서 get사용
            int i = cls[1];
            Console.WriteLine("{0} {1} {2}",cls[1],i,cls[0]);//1024 1024 0출력
        }
    }
}
