using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_milestone
{
    //details for eliglbe students
    internal class Promotion
    {
        private Discounts discounts;

        public Promotion()
        {
            discounts = new Discounts();
        }
        public decimal CheckPromotion(Student student)
        {
            decimal discountPercentage = discounts.CalculateDiscount(GetAge(student.DateOfBirth), student.Gender);
            return discountPercentage;
        }
        private int GetAge(DateTime dateOfBirth) 
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
                if(DateTime.Now< dateOfBirth.AddYears(age) );

            return age;
        }
    }
}
