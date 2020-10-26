using System;
using System.Data;

namespace Interface
{
    /*인터페이스 : 메소드, 속성, 이벤트, 인덱서 등을 갖지만, 인터페이스는 구현하지 않고 정의만을 가짐
     *추상멤버로만 구성된 추상 base클래스와 개념적으로 유사
     * 인터페이스는 여러개의 기준 클래스를 가질수 있음
     * interface 키워드를 사용하여 정의, 정의시 내부멤버들에대해 접근제한자 사용하지 않음
     * 인터페이스를 잘정의하고 사용하는 것은 매우 중요
     * 비지니스를 객체지향프로그래밍으로 디자인하고 구현하는데 가장 중요한 핵심
     */
    public interface IComparable
    {
        int CompareTo(object obj);
    }
    public class Myclass : IComparable
    {
        private int key;
        private int value;
        public int CompareTo(object obj)//CompareTo를 재정의
        {
            Myclass target = (Myclass)obj;
            return this.key.CompareTo(target.key);
        }
    }
   
    /*
    public void Run()
    {
        // 인터페이스 사용하기 때문에
        // 특정 DB Connection을 신경 쓸 필요가 없다
        IDbConnection dbCon = GetDbConnection();
        dbCon.Open();
        if (dbCon.State == ConnectionState.Open)
        {
            dbCon.Close();
        }
    }

    // IDbConnection 인터페이스를 리턴
    public IDbConnection GetDbConnection()
    {
        IDbConnection dbConn = null;
        string cn = ConfigurationManager.AppSettings["Connection"];
        switch (ConfigurationManager.AppSettings["DbType"])
        {
            case "SQLServer":
                dbConn = new SqlConnection(cn);
                break;
            case "Oracle":
                dbConn = new OracleConnection(cn);
                break;
            case "OleDB":
                dbConn = new OleDbConnection(cn);
                break;
        }
        return dbConn;
    }*/
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
