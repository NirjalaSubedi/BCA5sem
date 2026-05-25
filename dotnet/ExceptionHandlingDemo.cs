namespace ExceptionHandlingDemo
{
    class Program
    {
        public static void ExceptionHandling()
        {
            int a,b,c;
            Console.WriteLine("Enter any two Numbers");
            try
            {
                a=int.Parse(Console.ReadLine());
                b=int.Parse(Console.ReadLine());
                c=a/b;
                Console.WriteLine("Result"+c);
            }
            catch (DivideByZeroException dbe)
            {
                Console.WriteLine("error:"+dbe);
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}