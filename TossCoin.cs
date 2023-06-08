namespace BasicCode
{
    internal class TossCoin
    {
        static int toss()
        {
            Random r = new Random();
            int a = r.Next(2);

            return a;
        }

        static void tossacoin()
        {
            int heads = 0;
            int tails = 0;
            Console.WriteLine("How many times you want to toss a coin");
            int turns = int.Parse(Console.ReadLine());
            for (int i = 0; i < turns; i++)
            {
                int temp = toss();
                if (temp == 0)
                {
                    heads++;
                }
                else { tails++; }
            }

            if (heads < tails)
            {
                Console.WriteLine("tails got " + tails + " votes so tails won this game");
            }
            else
            {
                Console.WriteLine("heads won the game " + heads);
            }
        }
        static void Main(string[] args)
        {
            //tossacoin();
            //LeapYear ly = new LeapYear();
            //ly.leapyear();
            //Powerof2 p2 =new Powerof2();
            //p2.power();
            //HarmonicNumber hm = new HarmonicNumber();
            //hm.HarmonicNumberr();
            //PrimeFactor pf = new PrimeFactor();
            //pf.prime();
            //QuotientRemainder qr = new QuotientRemainder();
            //qr.findQuotient();
            //swapNumbers swapNumbers = new swapNumbers();
            //swapNumbers.swap();
            //evenodd evenodd = new evenodd();    
            //evenodd.oodeven();
            //vowel vowel = new vowel();
            //vowel.Checkvowel();
            //FindLargest find = new FindLargest();
            //find.FindLargestNumber();
            //FibonacciSeries fs = new FibonacciSeries();
            //fs.Fibonacciseries();
            //perfectNumber pn = new perfectNumber();
            //pn.perfectnumber();
            //PrimeNumber pm = new PrimeNumber();
            //pm.prime();
            reverseNumber rn = new reverseNumber(); 
            rn.revserse();
        }
    }
}