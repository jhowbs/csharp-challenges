using System;
using System.Runtime.Serialization;

namespace ChallengeForUs
{
    public class AbsSum
    {
        private int[] numbers = new int[0];
        private int[] sumPos0 = new int[] {0};
        int receiveValue = 0;
        public int[] ASum { 

            get
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0) numbers[i] = numbers[i]*(-1);
                    receiveValue = receiveValue + numbers[i];
                }
                sumPos0[0] = receiveValue;
                return sumPos0;
            }
            set
            {
                numbers = value;
            } 
        }
               

    }
}