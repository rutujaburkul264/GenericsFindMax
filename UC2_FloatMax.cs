using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFloatMaximum
{
    class FlaotMax
    {
        public static double MaximumFloatCheck(double firstNo,double secondNo,double thirdNo)
        {
            if(firstNo.CompareTo(secondNo) > 0  && (firstNo.CompareTo(thirdNo) > 0))
            {
                return firstNo;
            }
            if(secondNo.CompareTo(firstNo) > 0 && (secondNo.CompareTo(thirdNo) > 0))
            {
                return secondNo;
            }
            if(thirdNo.CompareTo(firstNo) > 0 && (thirdNo.CompareTo(secondNo) > 0))
            {
                return thirdNo;
            }
            throw new Exception("Firstvalue,secondvalue and thirdvalue is same");
        }
    }
}
