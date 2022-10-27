using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC4ValidateMobile
    {
        public void CheckMobileNumber()
        {
            //mobile number regex
            String nameRegex = "^([0-9]{2})\\s[6-9]{1}[0-9]{9}$";
            //here \\s for space $ to fix the size
            //^([0-9]{2}) fix first 2 digit
            Console.Write("Enter the Mobile number with the country code: ");
            String mobileNumber = Console.ReadLine();
            //compare the mobile regex with the user entered mobile number
            bool valid = Regex.IsMatch(mobileNumber, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
