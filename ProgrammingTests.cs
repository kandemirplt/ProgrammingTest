using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Tests
{
    [TestClass()]
    public class ProgrammingTests
    {
        [TestMethod()]
        public void Test1Test()
        {
            Programming p = new Programming();
            int[] a = { -1, -22, -3, -4, -6, -2, 4, 2, 1, 6, 3, 1, 4, 8, 5 };

            int x = p.Test1(a);

        }

        [TestMethod()]
        public void Test2Test()
        {
            Programming p = new Programming();
            string a = p.Test2(7200);
        }

        [TestMethod()]
        public void Test3Test()
        {
            Programming p = new Programming();
            string a = p.Test3(3, 0, 7, 0);
            string b = p.Test3(2, 4, 0, 0);
            string c = p.Test3(9, 1, 9, 7);
            string d = p.Test3(1, 8, 3, 2);

        }

        [TestMethod()]
        public void Test4Test()
        {
            Programming p = new Programming();

            int[] a = { 1,3,4,6,7,8,8,8,8,9,9,11,13,13 };
            p.Test4(a, 8);
        }
    }
}



//using System;
//using System.Linq;
//// you can also use other imports, for example:
//// using System.Collections.Generic;

//// you can write to stdout for debugging purposes, e.g.
//// Console.WriteLine("this is a debug message");

//class Solution
//{
//    public string solution(int A, int B, int C, int D)
//    {

//        if (!validateParam(A) ||
//              !validateParam(B) ||
//              !validateParam(C) ||
//              !validateParam(D))
//        {
//            return string.Empty;
//        }

//        int[] hours = { joinParams(A, B, C, D),
//                            joinParams(A, B, D, C),
//                            joinParams(A, C, B, D),
//                            joinParams(A, C, D, B),
//                            joinParams(A, D, C, B),
//                            joinParams(A, D, B, C),

//                            joinParams(B, A, C, D),
//                            joinParams(B, A, D, B),
//                            joinParams(B, C, A, D),
//                            joinParams(B, C, D, A),
//                            joinParams(B, D, C, A),
//                            joinParams(B, D, A, C),

//                            joinParams(C, A, B, D),
//                            joinParams(C, A, D, B),
//                            joinParams(C, B, A, D),
//                            joinParams(C, B, D, A),
//                            joinParams(C, D, B, A),
//                            joinParams(C, D, A, B),

//                            joinParams(D, A, C, B),
//                            joinParams(D, A, B, C),
//                            joinParams(D, B, A, C),
//                            joinParams(D, B, C, A),
//                            joinParams(D, C, A, B),
//                            joinParams(D, C, B, A),

//            };
//        if (hours.Where(x => x > 0).Count() < 1)
//        {
//            return "NOT POSSIBLE";
//        }
//        int[] orderedArray = hours.OrderBy(x => x).ToArray();

//        return findTime(orderedArray.Max(x => x)).ToString();
//    }

//    private bool validateParam(int A)
//    {
//        if (A < 0 || A > 9)
//        {
//            return false;
//        }

//        return true;
//    }

//    private int joinParams(int a, int b, int c, int d)
//    {
//        int minute = (Convert.ToInt32(a.ToString() + b.ToString()) * 60) + Convert.ToInt32(c.ToString() + d.ToString());
//        if (minute >= 1440)
//        {
//            return -1;
//        }
//        if (minute == 1244)
//        {

//        }

//        return minute;
//    }

//    private string findTime(int T)
//    {
//        if (T < 0 || T >= 1440)
//        {
//            return string.Empty;
//        }
//        int hourParam = 60;
//        int saat = T / hourParam;
//        int dakika = T % hourParam;

//        return saat.ToString().PadLeft(2, '0') + ":" + dakika.ToString().PadLeft(2, '0');
//    }
//}