using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class GeneralFunctions
    {
        public string GetDiscount(int Age)
        {
            if (Age > 60)
                return "Discount is 60%";
            else if (Age >= 40 && Age <= 60)
                return "Discount is 40%";
            else
                return "No Discount";
        }

    }
}
