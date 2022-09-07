using System;

namespace ChallengeForUs
{
    public class ShuffleName
    {
        private string name = "";
        private string[] separator = {" "};
        private string[] nameAsArray = {","};
        public string ShuffleN
        {
            get 
            { 
                nameAsArray = name.Split(separator,2, StringSplitOptions.RemoveEmptyEntries);
                name = nameAsArray[1] + " " + nameAsArray[0];
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
        
    }
}