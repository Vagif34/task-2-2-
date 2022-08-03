using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name =  "salam usaqlar necesiz" ;
            int count = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] =='a')
                {
                    count++;
                }
            }
            if (count >= 1)
            {
                Console.WriteLine("a herfi var");

            }
            else
            {
                Console.WriteLine("a herfi yoxdur");
            }
        }
    }
}
