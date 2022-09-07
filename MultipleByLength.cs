namespace ChallengeForUs
{
    class MultipleByLength
    {
        public int[] MultipleByLengthCalc(int[] array)
        {
            //int[] multiple = new int[0];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = array[i]*array.Length;
            }
            return array;
        }
    }
}