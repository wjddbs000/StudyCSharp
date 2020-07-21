using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
public enum BaseMode
{
    NONE, //기본 상태
    INSERT, //입력
    UPDATE, //수정
    DELETE, 
    SELECT
}

namespace BookRentalShopApp2020
{
    public class Commons
    {
        public static string USERID = string.Empty;
        //공통 DB 연결문자열
        public static readonly string CONNSTR = "Data Source=localhost;Port=3306;DataBase=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";
        /// <summary>
        /// Md5 함호화 메서드
        /// </summary>
        /// <param name="md5Hash">해시키값</param>
        /// <param name="input">평문</param>
        /// <returns>암호화된 문자열</returns>
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
