
namespace ClassExcercise {
    class Program
    {
        public static void Main()
        {
            double rate = 0.055;
            float principal = 100;
            short time = 4;
            short numberCompounded = 1;

            CompoundInterest.CalculateInterestAndAmount(rate, principal, time, numberCompounded);

           
        }


        class  CompoundInterest
        {
            public static void CalculateInterestAndAmount(double rate, float principal, short time, short numberCompounded)

            {
                decimal amount = (decimal)(principal * Math.Pow(1 + rate / numberCompounded, time  * numberCompounded));

                decimal compoundInterest = amount - (decimal)principal;
                
                Console.WriteLine("Amount is equal to " + amount);


                Console.WriteLine("The compound interest is " + compoundInterest);

                
            }
        }
    }



    }








