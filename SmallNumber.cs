using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeForUs
{
    public class SmallNumber
    {
        public string SmallerNumb(string numberOne, string numberTwo)
        {
            var stringToNumberOne = Convert.ToInt32(numberOne);
            var stringToNumberTwo = Convert.ToInt32(numberTwo);

            if (stringToNumberOne > stringToNumberTwo)
            {
                return stringToNumberOne.ToString();
            }
            else if(stringToNumberTwo > stringToNumberOne)
            {
                return stringToNumberTwo.ToString();
            }
            else
            {
                return "EQUAL";
            }
        }  
        
    }
}