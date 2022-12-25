namespace Discrete_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            long n1 =long.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            long n2=long.Parse(Console.ReadLine());

            if(n1<1)
            {

                n1 = 1;

            }

            for(long i = n1; i <= n2 ; i++)
            {
                if (Perfect(i))
                {

                    Console.WriteLine(i);
               
                }

            }
       
        }

        static bool Perfect(long n)
        {
            long sum = 0;
            
            for (long i = 1; i <= n/2; i++)
            {
            
                if (n % i == 0)
                {
                
                    sum += i;
                
                }

            }
            if (sum == n)
            {

                return true;

            }
           
            return false;
           
        }
    
     
    
    }

}