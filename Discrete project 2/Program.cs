namespace Discrete_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            
            long n =long.Parse(Console.ReadLine());

            long sum = 0;

            for(int i = 1; i <= n/2 ; i++)
            {

                if (n % i == 0)
                {

                    sum += i;
                    
                }
            
            }

            if (sum == n)
            {

                Console.WriteLine(n + " is perfect");
            
            }

            else
            {
            
                Console.WriteLine(n + " is not perfect");
            
            }

        }
    }
}