using System;

namespace ChallengeForUs
{
    public class ConvertNumberMonth
    {
        private string month = "";
        public string NumberMonth { 
            get
            {
                switch (month)
                {
                    case "1":
                    return "January";
                    
                    case "2":
                    return "February";
                    
                    case "3":
                    return "March";
                     
                    case "4":
                    return "April";
                    
                    case "5":
                    return "May";
                    
                    case "6":
                    return "June";
                    
                    default:
                    return "Nenhum numero válido foi passado";
                }
            } 
            set
            {
                month = value;
            } 
        }
    }
}