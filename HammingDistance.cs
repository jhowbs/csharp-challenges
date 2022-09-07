namespace ChallengeForUs
{
    class HammingDistance
    {
        public int HammingD(string caracteres1, string caracteres2)
        {
            string[] letrasArray = new string[100];    
            int diffQuantity =0;
            if (caracteres1.Length == caracteres2.Length){
                for (int i = 0; i < caracteres1.Length; i++)
                {
                    if (!(caracteres1.Substring(i, 1) ==
                    caracteres2.Substring(i, 1)))
                    {
                        diffQuantity = diffQuantity + 1;
                    }                    
                }
                Console.WriteLine(diffQuantity);
            }
            else
            {
                diffQuantity = 0;
            }
            return diffQuantity;
        }
    }
}