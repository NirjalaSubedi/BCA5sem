namespace HCFFinding{
    class HCF 
    {
        public static void hcfoftwonumbers(int a ,int b)
        {
            int num1=a;
            int num2=b;
            while (b != 0)
            {
                int temp=b;
                b=a % b;
                a=temp;
            }
            Console.WriteLine($"HCF of {num1} {num2} is: {a}");
        }

        public static void hcfusingforloop()
        {
            int a,b,hcf=1;
            Console.WriteLine("enter first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b=Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= (a < b ? a : b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    hcf = i; 
                } 
            }
            Console.WriteLine($"HCF IS {hcf}");

        }
    }
}