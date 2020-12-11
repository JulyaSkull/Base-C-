using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    class Information_to_check
    {
        static object[] PlusCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { -1, 0, -1},
            new object[] { 45, 3, 48 },
            new object[] { 10.34, 11, 21.34 }
        };
        static object[] MinusCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { 5, 2, 3 },
            new object[] { 10, 4.5, 5.5 },
            new object[] { 23, -32 , 55 }
        };
        static object[] DivisionCases =
       {
            new object[] { 45, 9, 5 },
            new object[] { 32, 8, 4 },
            new object[] { 62, 2, 31 },
            new object[] { 10, 4, 2.5 }
        };

        static object[] MultiplicationCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { -2, -2, 4 },
            new object[] { -5, 5, -25 },
            new object[] { 10, 0.5, 5 }
        };
    }
}
