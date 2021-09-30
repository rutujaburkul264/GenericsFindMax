using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class UC4_MoreThan5Parameters
    {
        public static int MaximumIntegerNumber(int firstNo, int secondNo, int thirdNo,int fourthNo,int fifthNo)
        {
            if (firstNo.CompareTo(secondNo) > 0 && firstNo.CompareTo(thirdNo) > 0)
            {
                return firstNo;
            }
            if (secondNo.CompareTo(firstNo) > 0 && secondNo.CompareTo(fourthNo) > 0)
            {
                return secondNo;
            }
            if (thirdNo.CompareTo(secondNo) > 0 && thirdNo.CompareTo(fifthNo) > 0)
            {
                return thirdNo;
            }
            if (fourthNo.CompareTo(thirdNo) > 0 && fourthNo.CompareTo(fifthNo) > 0) 
            {
                return fourthNo;
            }
            throw new Exception("First,Second and Third Value is same");
        }
        public static double MaximumFloatCheck(double firstNo, double secondNo, double thirdNo,double fourthNo,double fifthNo)
        {
            if (firstNo.CompareTo(secondNo) > 0 && firstNo.CompareTo(thirdNo) > 0)
            {
                return firstNo;
            }
            if (secondNo.CompareTo(firstNo) > 0 && secondNo.CompareTo(fourthNo) > 0)
            {
                return secondNo;
            }
            if (thirdNo.CompareTo(secondNo) > 0 && thirdNo.CompareTo(fifthNo) > 0)
            {
                return thirdNo;
            }
            if (fourthNo.CompareTo(thirdNo) > 0 && fourthNo.CompareTo(fifthNo) > 0)
            {
                return fourthNo;
            }
            throw new Exception("Firstvalue,secondvalue and thirdvalue is same");
        }
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString,string fourthString, string fifthString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(fourthString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(fourthString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(fourthString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(fifthString) > 0 ||
                thirdString.CompareTo(secondString) >= 0 && thirdString.CompareTo(fifthString) > 0 ||
                thirdString.CompareTo(secondString) > 0 && thirdString.CompareTo(fifthString) >= 0)
            {
                return thirdString;
            }
            if (fourthString.CompareTo(thirdString) > 0 && fourthString.CompareTo(fifthString) > 0 ||
                fourthString.CompareTo(thirdString) >= 0 && fourthString.CompareTo(fifthString) > 0 ||
                fourthString.CompareTo(thirdString) > 0 && fourthString.CompareTo(fifthString) >= 0)
            {
                return fourthString;
            }

            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
