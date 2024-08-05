using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_milestone
{
     class Discounts
    {
        //caluculations for students who are eligeble for a discount
        public decimal CalculateDiscount(int age, string gender)
        {
            decimal discountPercentage = 0;

            if(age > 25) 
            {
                if (gender.ToLower() == "female")
                    discountPercentage = 0.3m;

                else if (gender.ToLower() == "male")
                    discountPercentage = 0.19m;
            }
            return discountPercentage;
        }
    }
}
