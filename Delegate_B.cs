using System;

namespace Delegate_B
{
    /*
     * delegate는 클래스의 필드나 속성에 사용될 수 있음
     */
    class MyArea : Form
    {
        public MyArea()
        {
            // 이 부분은 당분간 무시 (무명메서드 참조)
            // 예제를 테스트하기 위한 용도임.
            this.MouseClick += delegate { MyAreaClicked(); };
        }

        public delegate void ClickDelegate(object sender);

        // Delegate 필드
        public ClickDelegate MyClick;

        // 필드 대신 Delegate 속성으로도 가능
        //public ClickDelegate Click { get; set; }

        //...
        //...

        // 예제를 단순화 하기 위해
        // MyArea가 클릭되면 아래 함수가 호출된다고 가정
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }

    class Program
    {
        static MyArea area;

        static void Main(string[] args)
        {
            area = new MyArea();
            area.MyClick = Area_Click;
            area.ShowDialog();
        }

        static void Area_Click(object sender)
        {
            area.Text = "MyArea 클릭!";
        }
    }

    class Program
    {
        static MyArea area;

        static void Main(string[] args)
        {
            area = new MyArea();

            //복수개의 메서드를 delegate에 할당
            area.MyClick += Area_Click;
            area.MyClick += AfterClick;
            //연산자를 이용해 여러개의 메서드를 할당하는 것이 가능
            //복수의 메소드가 할당된 delegate가 실행될때 invocationList로부터 순서대로 메소드를 하나씩 가져와 실행
            area.ShowDialog();
        }

        static void Area_Click(object sender)
        {
            area.Text += " MyArea 클릭! ";
        }

        static void AfterClick(object sender)
        {
            area.Text += " AfterClick 클릭! ";
        }
        /*
         * delegate에서 event로
         * delegate는 할당연산자(=)를 사용할수 있다.
         * 할당연산자 사용시 기존에 가입된 모든 메소드리스트는 지워지고
         * 마지막에 할당된 메소드 한개만 invocationnList에 넣게 된다
         * 이를 할당연산자를 사용할수없는 event를 사용해 해결한다
         * 이벤트핸들러 추가(+=), 이벤트핸들러 삭제(-=)만 가능
         */
         /*
          * delegate vs 함수포인터
          * 1. 함수포인터는 외부의 어떤 함수에 대한 주소값만을 가짐
          * but. delegate는 클래스 객체의 인스턴스 메서드에 대한 레퍼런스를 갖기위해
          * 객체의 주소와 메서드의 주소를 함께가짐
          * 2. C의 함수 포인터는 하나의 함수포인터를 가짐
          * but. delegate는 하나이상의 메서드 레퍼런스를 가질수 있어서 multicast가능
          * 3. C의 함수포인터는 타입 안정성을 완전히 보장하지 않는다.
          * but. deleate는 엄격하게 타입 안정성을 보장
          */
    }
}
