using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            //int[] intArray = { 432, 132, 980, 321 };
            //GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            //generic.PrintMaxValue();
            //#endregion

            //#region
            //double[] doubleArray = { 19.5, 85.4, 95.8 };
            //GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            //genericDouble.PrintMaxValue();
            //#endregion

            //#region
            //string[] stringArray = { "666", "321", "635" };
            //GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //genericString.PrintMaxValue();
            //#endregion

            //#region
            //int[] intArray = { 432, 132, 980 };
            //GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            //generic.PrintMaxValue();

            //double[] doubleArray = { 85.4, 95.8, 67.1 };
            //GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            //genericDouble.PrintMaxValue();

            //string[] stringArray = { "321", "22", "1111" };
            //GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //genericString.PrintMaxValue();
            //#endregion

            #region
            int[] intArray = { 432, 132, 980, 650, 730 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 85.4, 95.8, 67.1, 45.5, 85.3 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "321", "22", "1111", "432", "560" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            #endregion
        }
    }      
}
