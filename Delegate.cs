using System;

namespace Delegate
{
    /*
     * delegate : 메소드를 다른 메소드로 전달할 수 있도록 하기위해 만들어 짐
     * delegate는 메소드의 입력 파라미터로 피호출자에게 전달될 뿐만아니라
     * 메소트의 리턴값으로 호출자에게 전달할 수 도 있음
     * delegate int Mydelegate(string s); 처럼 정의함
     * delegate정의에서 중요한 것은 입력 파라미터들과 리턴타입이다
     */
    class MySort
    {
        // 델리게이트 CompareDelegate 선언
        public delegate int CompareDelegate(int i1, int i2);
        //두개의 인자 1개의 리턴을 갖는 delegete생성

        public static void Sort(int[] arr, CompareDelegate comp)
        {
            if (arr.Length < 2) return;
            Console.WriteLine("함수 Prototype: " + comp.Method);

            int ret;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    ret = comp(arr[i], arr[j]);//AscendingCompare메소드가 실행됨
                    if (ret == -1)
                    {
                        // 교환
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            Display(arr);
        }
        static void Display(int[] arr)
        {
            foreach (var i in arr) Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
            (new Program()).Run();
        }
        // 델리게이트 정의
        delegate int MyDelegate(string s);//s==stringtoint

        void Test()
        {
            //델리게이트 객체 생성
            MyDelegate m = new MyDelegate(StringToInt);

            //델리게이트 객체를 메서드로 전달
            Run(m);
        }

        // 델리게이트 대상이 되는 어떤 메서드
        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        // 델리게이트를 전달 받는 메서드
        void Run(MyDelegate m)//mydelegate가 호출
        {
            // 델리게이트로부터 메서드 실행
            int i = m("123");//stringtoint 메소드가 호출되어 실행

            Console.WriteLine(i);
        }
        void Run()
        {
            int[] a = { 5, 53, 3, 7, 1 };

            // 올림차순으로 소트
            MySort.CompareDelegate compDelegate = AscendingCompare;
            //AscendingCompare가 실행될 메소드가됨
            MySort.Sort(a, compDelegate);

            // 내림차순으로 소트
            compDelegate = DescendingCompare;
            MySort.Sort(a, compDelegate);
        }

        // CompareDelegate 델리게이트와 동일한 Prototype
        int AscendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i2 - i1) > 0 ? 1 : -1;
        }

        // CompareDelegate 델리게이트와 동일한 Prototype
        int DescendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i1 - i2) > 0 ? 1 : -1;
        }
    }

}

