using System;

using System.Globalization;

 

class NumberFormatInfoSample
{
    // pulled from 
    // https://www.c-sharpcorner.com/UploadFile/0f68f2/converting-a-number-in-currency-format-for-different-culture/

    public static void Main()
    {

        // Gets a NumberFormatInfo associated with the USA culture.

        NumberFormatInfo myNumberFormatInfo = new CultureInfo("en-US", false).NumberFormat;

        // Displays a value with the default separator

        long myInt = 55555555554444333;

        Console.WriteLine("\nDisplays a value with the default separator ");

        Console.WriteLine(myInt.ToString("C", myNumberFormatInfo));

        // Displays the same value with different groupings.

        int[] mySizes1 = { 2, 4, 3 };

        int[] mySizes2 = { 2, 4, 0 };

        myNumberFormatInfo.CurrencyGroupSizes = mySizes1;

        Console.WriteLine("\nDisplays the same value with different group {2,4,3}  ");

        Console.WriteLine(myInt.ToString("C", myNumberFormatInfo));

        myNumberFormatInfo.CurrencyGroupSizes = mySizes2;

        Console.WriteLine("\nDisplays the same value with different group {2,4,0}  ");

        Console.WriteLine(myInt.ToString("C", myNumberFormatInfo));

        Console.Read();
    }

} 
