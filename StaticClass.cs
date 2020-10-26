using System;

namespace StaticMethod
{
    /*정적 메소드는 인스턴스 메소드와 달리 직접 [클래스명,메소드명]형식으로 호출하는메소드다
     * static클래스 : 모든 클래스멤버가 static멤버로 되어있으며 클래스명앞에 static이라는 키워드로 정의
     * static클래스는public생성자를 가질수 없지만 static생성자는 가질수 있음
     * static생성자는 주로 static필드들을 초기화하는데 사용
     * 
     */
     public class Myclass
    {
        private int val = 1;
        public int InstRun()
        {
            return val;
        }
        public static int Run()
        {
            return 1;
        }
    }
    public class Cient
    {
        public void Test()
        {
            Myclass myclass = new Myclass();
            int i = myclass.InstRun();
            //인스턴스메소드/ 객체명,메소드명으로 호출
            int j = Myclass.Run();
            //정적메소드/ 클래스명,메소드명으로 호출
        }
    }
    public static class MyUtility
    {
        private static int ver;
        static MyUtility()//static생성자로 ver초기화
        {
            ver = 1;
        }
        public static string Convert(int i)
        {
            return i.ToString();
        }
        public static int ConvertBack(string s)
        {
            return int.Parse(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = MyUtility.Convert(123);
            int i = MyUtility.ConvertBack(str);
            Console.WriteLine("{0}",i);//123
        }
    }
}
