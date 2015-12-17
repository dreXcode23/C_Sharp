using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class DeliveryCharges
    {
        static void Main(string[] args)
        {
            int[] zipCode = new int[] { 63130, 63025, 63105, 63132, 63375, 63113, 63034, 91210, 63141, 63011 };
            double[] deliveryPrice =  { 6.50,   5.25,  6.00,  7.30,  6.00,  8.50, 10.25, 32.20, 25.75, 9.00};
            int areaCode;
            double cost = 0;
            bool isValidZip = false;

            Write("Enter your zip code: ");
            areaCode = Convert.ToInt32(ReadLine());

            for (int x = 0; x < zipCode.Length; ++x)
            {
                if (areaCode == zipCode[x])
                {
                    isValidZip = true;
                    areaCode = zipCode[x];
                    cost = deliveryPrice[x];
                }
            }
            if (isValidZip)
            {
                WriteLine("\nYour zipcode {0} IS in the company's delivery area.", areaCode);
                WriteLine("Your cost will be {0:c}", cost);
            }
            else
            {
                WriteLine("\nYour zipcode {0} is NOT in the company's delivery area.", areaCode);
            }
        }
    }
}
