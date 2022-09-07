using System;
using System.Runtime.Serialization;
namespace ChallengeForUs
{
    class ChallengeForUs
    {

        static ChallengeForUs() 
        {

        }
        static void Main(string[] args) 
        {
            ConvertNumberMonth convertNumberMonth = new ConvertNumberMonth();
            FindMinMax findMinMax = new FindMinMax();
            AbsSum absoluteSum = new AbsSum();
            ToTherPowerOf toTherPowerOf = new ToTherPowerOf();
            MultipleByLength multipleByLength = new MultipleByLength();
            HammingDistance hammingDistance = new HammingDistance();
            ShuffleName shuffleName = new ShuffleName();

            bool keepRunning = true;
            do
            {
                Console.WriteLine("Please choose the challenge that you desire to test, A to G."+ "\n");
                Console.WriteLine("If you want to live, press Z."+ "\n");
                string challengeTest = "";
                string challengeParameters = "";
                char[] separator = {'-', ',', ';', ' '};
                challengeTest = Console.ReadLine() ?? throw new ArgumentNullException(challengeTest);
                Console.WriteLine("\n");

                switch (challengeTest)
                {

                    case "A":

                        Console.WriteLine("Please insert a number from 1 to 12, them the app will convert for a month."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        convertNumberMonth.NumberMonth = challengeParameters;
                        Console.WriteLine(convertNumberMonth.NumberMonth + "\n");
                        break;

                    case "B":

                        int[] supportArrayB= new int[100];
                        Console.WriteLine("Please insert your numbers separeted by -, them the app will collect greatest and the smallest number, and press enter."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        string[] stringListB = challengeParameters.Split(separator);
                        for (var i = 0; i < stringListB.Length; i++)
                        {
                            supportArrayB[i] = Int32.Parse(stringListB[i]);
                        }
                        findMinMax.MinMax = supportArrayB;
                        Console.WriteLine("Maximum value: " + findMinMax.MinMax[0] + "\n");
                        Console.WriteLine("Minimum value: " + findMinMax.MinMax[1] + "\n");
                        break;

                    case "C":

                        int[] supportArrayC= new int[100];
                        Console.WriteLine("Please insert your numbers separeted by ','(virgula); don't matter if they are positive or negative and press enter. Them the app will calculate the Absolute Sum"+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        string[] stringListC = challengeParameters.Split(separator);
                        for (var i = 0; i < stringListC.Length; i++)
                        {
                            supportArrayC[i] = Int32.Parse(stringListC[i]);
                        }
                        absoluteSum.ASum = supportArrayC;
                        Console.WriteLine("Absolute sum: " + absoluteSum.ASum[0] + "\n");
                        break;

                    case "D":

                        Console.WriteLine("Please insert your number and press enter. Them the the app will calculte its respective pow."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        toTherPowerOf.PowerPow = Int32.Parse(challengeParameters);
                        Console.WriteLine("Pow result:" + toTherPowerOf.PowerPow + "\n");
                        break;

                    case "E":

                        Console.WriteLine("Please insert your numbers separeted by ','(virgula) and press enter. Them the app will calculate the number multiplied by the total numbers quantity inserted."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        int[] supportArrayE= new int[100];
                        string[] stringListE = challengeParameters.Split(separator);
                        for (var i = 0; i < stringListE.Length; i++)
                        {
                            supportArrayE[i] = Int32.Parse(stringListE[i]);
                        }
                        supportArrayE = multipleByLength.MultipleByLengthCalc(supportArrayE);
                        for (var i = 0; i < supportArrayE.Length; i++)
                        {
                            Console.WriteLine(supportArrayE[i]);
                        }
                        break;

                    case "F":

                        Console.WriteLine("Please insert 2 caracter list separeted by ','(virgula) and press enter. Them the app will check if they are equal, and if isn't it will indicate how many caracteres."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        string[] stringListF = challengeParameters.Split(separator);
                        int hamming = hammingDistance.HammingD(stringListF[0],stringListF[1]);
                        Console.WriteLine(hamming);
                        break;

                    case "G":

                        Console.WriteLine("Please insert a name and last name separated by space. Them the the app will invert its respective order."+ "\n");
                        challengeParameters = Console.ReadLine() ?? throw new ArgumentNullException(challengeParameters);
                        shuffleName.ShuffleN = challengeParameters;
                        Console.WriteLine(shuffleName.ShuffleN);
                        break;

                    case "Z":

                        Console.WriteLine("The application will close");
                        keepRunning = false;
                        break;

                    default:

                        Console.WriteLine("Este teste não existe, esta aplicação irá fechar.");
                        keepRunning = false;
                        break;
                }
            } while (keepRunning);     

        }
    }
}