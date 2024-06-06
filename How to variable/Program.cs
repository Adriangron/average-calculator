namespace How_to_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num01;
            int num02;
            int num03;

            Console.WriteLine("Input a number");
           
            num01 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Input second number");

            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the final number");

            num03 = Convert.ToInt32(Console.ReadLine());

            int result = (num01 + num02 + num03) / 3;
            Console.WriteLine("The avarage of the numbers is " + result);

        }
    }
}
