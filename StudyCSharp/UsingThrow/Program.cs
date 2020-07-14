using System;

namespace Throw
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(2);
                DoSomething(9);
                //DoSomething(12);
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외발생 : {e.Message}");
                Console.WriteLine($"도움링크 : {e.HelpLink}");
                Console.WriteLine($"소스 : {e.Source}");
            }
            finally
            {
                Console.WriteLine("에러가 발생하지않았습니다.");
            }
        }
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception
                {
                    HelpLink = "http://www.naver.com",
                    Source = "UsingThrow line 34"
                };

        }
    }
}
