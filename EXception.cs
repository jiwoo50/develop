using System;

namespace Exception
{
    /*
     * C# Exception 예외처리 
     * C#에서는 try, catch, finally라는 키워드를 사용해 Exception을 핸들링함
     * try : 실제 실행하고 싶은 명령문들을 갖는 블럭, 에러 발생시 catch문에서 잡힘
     * catch : 모든 Exception을 잡거나 특정 Exception을 선별하여 잡는다. 하나 혹은 여러개 이기도 함
     * 모든 Exception : catch {...},catch (Exception ex){ ... }처럼 모든 Exception의 베이스 클래스인 System.Exception을 잡으면된다.
     * 특정 Exception : catch (ArgumentException ex){...}
     * finally : Exception 발생 여부와 관계없이 마지막에 반드시 실행되는 블럭
     */
    /*
     * C# throw
     * try에서 Exception이 발생했는데 catch에서 잡으면 Exception은 처리된것으로 간주
     * catch문에서 Exception을 상위 호출자로 보내는 경우 throw사용
     * 구분
     * 1. throw 문 다음에 catch에서 전달받은 Exception객체를 쓰는 경우
     * catch (Exception ex)에서 전달받은 Argument ex를 사용하는 경우.
     * ex의 예외정보 보전하지만, stack trace를 유실하여 throw문 이전의 콜스택정보 유실
     * 사용하지 않는 것이 좋음
     * 2. throw 문 다음에 새 Exception 객체를 생성해서 전달하는 경우
     * 새로운 Exception 객체를 만들어 던지기 위해 throw ne myException();처럼
     * C#의 new를 사용해 새로운 객체를 만든후 throw하면 된다.
     * inner Exception을 포함하지 않는 경우 기존 Exception 정보를 잃을 가능성 있음 
     * 3. throw 문 다음에 아무것도 없는 경우
     * catch문에서 잡힘 Exception을 그대로 상위 호출 함수에게 전달하는 일을 한다.
     * throw와 동일한 메소드에서 에러 발생시 동일 메소드의 어느라인에서 에러가 발생했는지 포함 않함
     */
    class Program
    {
        //예제
        static void Main(string[] args)
        {
            string connStr = "Data Source=(local);Integrated Security=true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;
            try
            {
                //실행파일
                conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)//SqlException에러 발생시 catch가 잡음
            {
                Console.WriteLine(ex.Message);//에러 메세지만 표시
                //예외가 처리된것으로 간주
            }
            finally//Finally는 항상 실행
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
 