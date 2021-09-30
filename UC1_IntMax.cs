namespace GenericsIntegerMaximum
{
    class UC1_IntMax
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
    }
}

