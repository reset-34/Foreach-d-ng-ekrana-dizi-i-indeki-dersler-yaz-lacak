using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_döngü_ekrana_dizi_içindeki_dersler_yazılacak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dersler = { "html", "css", "java", "c#" };

            foreach(string yazilacak in dersler)
            {
                Console.WriteLine(yazilacak);                
            }
            Console.ReadLine();
        }
    }
}
