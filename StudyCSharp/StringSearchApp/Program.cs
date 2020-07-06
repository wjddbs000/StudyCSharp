using System;
using System.Globalization;
using static System.Console;
namespace StringSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            //WriteLine(greeting);

            //WriteLine($"IndexOf 'Good' : {greeting.IndexOf("Good")}");
            //WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");

            //WriteLine($"IndexOf 'n' : {greeting.IndexOf('n')}");
            //WriteLine($"LastIndexOf 'n' : {greeting.LastIndexOf('n')}");

            //WriteLine($"StatrsWith 'Good' : {greeting.StartsWith("Good")}");
            //WriteLine($"StatrsWith 'Morning' : {greeting.StartsWith("Morning")}");

            //WriteLine($"Contains 'Good' : {greeting.Contains("Good")}");

            //WriteLine($"Replace 'Morning' to 'Evening' : " + $"{greeting.Replace("Morning","Evening")}");

            //WriteLine($"ToLower : {greeting.ToLower()}");
            //WriteLine($"ToUpper : {greeting.ToUpper()}");

            //WriteLine($"Insert : {greeting.Insert(greeting.IndexOf("Morning")-1," Very")}");

            //WriteLine($"Remove : {"I don't Love You".Remove(2,6)}");
            //WriteLine($"Trim : {" No Space ".Trim()}");
            //WriteLine($"Trim : {" No Space ".TrimStart()}");
            //WriteLine($"Trim : {" No Space ".TrimEnd()}");

            //string codes = "MSFT,GOOG,ANZN,AAPL,RHT";
            //var result = codes.Split(',');
            //foreach (var item in result)
            //{
            //    WriteLine($"each item {item}");
            //}
            //WriteLine($"substring : {greeting.Substring(0, 4)}");
            //WriteLine($"substring : {greeting.Substring(5)}");

            //WriteLine(string.Format("{0}DEF", "ABC"));
            //WriteLine(string.Format("{0,-10}DEF", "ABC"));
            //WriteLine(string.Format("{0,10}DEF", "ABC"));


            DateTime dt = DateTime.Now;
            WriteLine(string.Format($"{dt:yyyy-MM-dd HH:mm:ss}"));
            WriteLine(string.Format($"{dt:y yy yyy yyyy}"));
            WriteLine(string.Format($"{dt:M MM MMM MMMM}"));
            WriteLine(string.Format($"{dt:d dd ddd dddd}"));
            WriteLine(string.Format($"{dt:d/M/yyyy HH:mm:ss}"));

            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));

            decimal mvalue = 27000000m;
            WriteLine(string.Format($"price {mvalue:c}"));
            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("fr-FR")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));
        }
    }
}
