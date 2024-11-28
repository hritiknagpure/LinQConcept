using System.Linq;
namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 12, 23, 40, 21, 22, 45, 33, 20, 26, 75, 54, 36 };
           //Retrive value in Descending from write
          // i is Alias name
            var a = from i in age where i > 24 orderby i Descending  select i;
            var a = from i in age where i > 24 orderby i  select i;  
 
            foreach(int ele in a)
            {
                Console.WriteLine(ele);
            }
            Console.ReadLine();
        }

    }
}
