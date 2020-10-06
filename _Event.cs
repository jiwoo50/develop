using System;

namespace testevent
{
    /*
     * event : 클래스 내에 특정한 일이 일어났음을 외부의 이벤트 가입자들에게 알려주는 기능
     * 이벤트 핸들러 : 이벤트 발생시 어떤 명령을 실행할지 지정해주는 것
     *                 이벤트 가입을 위해 +=연산자로 이벤트핸들러를 이벤트에 추가
     *                 이벤트 핸들러 삭제는 -=연산자 사용
     *                 하나의 이벤트에는 다수의 이벤트 핸들러 추가 가능
     */
    class Program
    {
        // 예제 1. 클래스 내의 이벤트 정의
        class MyButton
        {
            public string Text;
            // 이벤트 정의
            public event EventHandler Click;

            public void MouseButtonDown()
            {
                if (this.Click != null)
                {
                    // 이벤트핸들러들을 호출
                    Click(this, EventArgs.Empty);
                }
            }
        }

        // 이벤트 사용
        public void Run()
        {
            MyButton btn = new MyButton();
            // Click 이벤트에 대한 이벤트핸들러로
            // btn_Click 이라는 메서드를 지정함
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";
            //....
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 클릭");
        }
        /*
         * add와 remove는 속성에서 get, set과 같은 역할을 한다.
         * 예제의 add와 remove를 보면서 공부
         */

         //예제 2
        class MyButton2
        {
            // 이벤트 정의하는 다른 방법
            private EventHandler _click;
            public event EventHandler Click
            {
                add
                {
                    _click += value;
                    // _click = value;   // 싱글캐스트
                }
                remove
                {
                    _click -= value;
                }
                //이 예제는 add는 += ,remove는 -=를 사용하고 있다. 
                //이는 value 델리게이트를 추가하거나 삭제하는 기능을 한다.
            }

            public void MouseButtonDown()
            {
                if (this._click != null)
                {
                    // 이벤트핸들러들을 호출
                    _click(this, EventArgs.Empty);
                }
            }

            /* 속성 정의
            private string _name;
            public string Name 
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            */
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
