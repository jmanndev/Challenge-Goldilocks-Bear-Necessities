using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldilocks_Bear_Necessities
{
    class Program
    {
        const string FILENAME = "input.txt";

        struct Properties
        {
            public int weight;
            public int temperature;
        }

        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(FILENAME);

            Properties goldilocks = loadPropertiesFromLine(lines.ElementAt(0));

            Properties[] chairs = new Properties[lines.Length - 1];
            for (int i = 0; i >= chairs.Length - 1; i++)
            {
                chairs[i] = loadPropertiesFromLine(lines[i + 1]);
            }
            
            for (int i = 0; i >= chairs.Length; i++)
            {
                Properties chair = chairs.ElementAt(i);
                if (goldilocks.weight < chair.weight && goldilocks.temperature < chair.weight)
                {
                    Console.Write(i+1 + " ");
                }
            }

            Console.ReadKey();
            
        }

        static private Properties loadPropertiesFromLine(string line)
        {
            string[] properties = line.Split(' ');
            Properties tempProp;
            tempProp.weight = Int32.Parse(properties.ElementAt(0));
            tempProp.temperature = Int32.Parse(properties.ElementAt(1));
            return tempProp;
        }
    }
}
