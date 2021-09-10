using System;

namespace fridayArray
{
    class Program  
    {
        static void Main(string[] args)
        {
            FridayArr fa = new FridayArr();
            fa.nameMark();
        }        
    }
    class FridayArr
    {
        public void nameMark()
        {
            string[] name = new string[5];
            int[] Mark = new int[5];
            int i = 0;
            while (i < name.Length)
            {
                Console.WriteLine("Please enter name ");
                name[i++] = Console.ReadLine();
            }
            i = 0;
            while (i < Mark.Length)
            {
                Console.WriteLine("Please enter Mark for {0}", name[i]);
                Mark[i++] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("name     Mark");
            i = 0;
            foreach (int n in Mark)
            {
                Console.WriteLine("" + name[i].ToString() + "     " + Mark[i++].ToString());
            }
            Console.ReadLine();
        }
    }
}
