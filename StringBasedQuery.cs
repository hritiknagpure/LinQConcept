using System.Linq;
namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] age = { 12, 23, 40, 21, 22, 45, 33, 20, 26, 75, 54, 36 };
            //var a = from i in age where i > 24   select i;

            String[] names = { "hritik","chirag","raj","dinesh","jatin","ramesh"};
            var a = from i in names where i.Contains("rag") select i;
                          //find rag in the names

            foreach(string ele in a)
            {
                Console.WriteLine(ele);
            }
            Console.ReadLine();
        }

    }
}
