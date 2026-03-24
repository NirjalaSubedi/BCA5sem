namespace HCFFinding{
    class HCF 
    {
        public static void hcfoftwonumbers(int a ,int b)
        {
            while (b != 0)
            {
                int temp=b;
                b=a % b;
                a=temp;
            }
            Console.WriteLine(a);
        }

        public static void hcfusingforloop()
        {
            int a,b,hcf=1;
            Console.WriteLine("enter first number");
            a=Convert.ToInt32(Console.ReadLine());
        }
    }
}