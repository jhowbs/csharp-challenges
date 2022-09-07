using System;

namespace ChallengeForUs
{
    public class FindMinMax
    {
        private int[] numbers = new int[100];
        private int[] selectedOnes = new int[] { 0, 0 };
        public int[] MinMax 
        { 
            get
            {
                int min = 0; int max = 0;
                for (int i = 0; i < numbers.Length ; i++)
                {
                    if (i == 0) 
                    {
                        min = numbers[0];
                        max = numbers[0];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                        selectedOnes[1] = min;
                    } 
                    else if (numbers[i] > max)
                    {
                        max = numbers[i];
                        selectedOnes[0] = max;
                    }
                }
                return selectedOnes;
            }
            set 
            {
                numbers = value;
            }
        
        }
    }
}