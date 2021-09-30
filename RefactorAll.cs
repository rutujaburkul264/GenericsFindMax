using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Refacror1_RefactorAll
    {
        public static int MaximumIntegerNumber(int firstNo, int secondNo, int thirdNo)
        {
            if (firstNo.CompareTo(secondNo) > 0 && firstNo.CompareTo(thirdNo) > 0)
            {
                return firstNo;
            }
            if (secondNo.CompareTo(firstNo) > 0 && secondNo.CompareTo(thirdNo) > 0)
            {
                return secondNo;
            }
            if (thirdNo.CompareTo(firstNo) > 0 && thirdNo.CompareTo(secondNo) > 0)
            {
                return thirdNo;
            }
            throw new Exception("First,Second and Third Value is same");
        }
        public static double MaximumFloatCheck(double firstNo, double secondNo, double thirdNo)
        {
            if (firstNo.CompareTo(secondNo) > 0 && (firstNo.CompareTo(thirdNo) > 0))
            {
                return firstNo;
            }
            if (secondNo.CompareTo(firstNo) > 0 && (secondNo.CompareTo(thirdNo) > 0))
            {
                return secondNo;
            }
            if (thirdNo.CompareTo(firstNo) > 0 && (thirdNo.CompareTo(secondNo) > 0))
            {
                return thirdNo;
            }
            throw new Exception("Firstvalue,secondvalue and thirdvalue is same");
        }
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }

            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
