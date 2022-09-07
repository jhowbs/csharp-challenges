namespace ChallengeForUs
{
    class ToTherPowerOf
    {
        private double number;
        public double PowerPow
        {
            get { 
                if (number < 0 || number == 0) return 0;
                return Math.Pow(number, number); }
            set { number = value; }
        }
        
    }
}