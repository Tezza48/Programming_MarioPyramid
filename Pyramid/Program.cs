using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            int heightInt = 0;
            while (!valid)
            {
                Console.Write("Height: ");
                string height = Console.ReadLine();
                valid = Int32.TryParse(height, out heightInt);
                if (heightInt <= 0 || heightInt >= 23)
                {
                    valid = false;
                }
            }
            int width = heightInt++;
            for (int i = 0; i < heightInt -1; i++)
            {
                string output = "";
                int hashCount = i + 2;
                for (int j = 0; j < hashCount; j++)
                {
                    output += "#";
                }
                 Console.WriteLine(output.PadLeft(width + 1));
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
