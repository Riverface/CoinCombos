using System;

namespace CoinCombos
{
    public class Counter
    {
        public int Nickels = 0;
        public int Dimes = 0;
        public int Pennies = 0;
        public int Quarters = 0;
        public int Ones = 0;
        public float Input;
        public Counter(float input)
        {
        Input = input;
        
        }

        public static void Main()
        {
        

        }


        public void CalculateChange()
        {

            for (float i = Input; Input > 0;)
            {
                if (Input % 1.00F == 0)
                {
                    i -= 1F;
                    Ones++;

                }
                if (Input % .25 == 0)
                {
                    i -= .25F;
                    Quarters++;
                }
                if (Input % .10 == 0)
                {
                    i -= .10F;
                    Dimes++;
                }   
                 if (Input % .05 == 0)
                {
                    i -= .05F;
                    Nickels++;
                }
                 if (Input % .01 == 0)
                {
                    i -= .01F;
                    Pennies++;
                }

            }

        }

    }
}