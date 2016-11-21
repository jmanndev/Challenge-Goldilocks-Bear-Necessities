using System;
using System.Linq;

namespace Goldilocks_Bear_Necessities
{
    class Program
    {
        const string FILENAME = "input.txt";

        static void Main()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(FILENAME);
            string line;
            int gWeight = 0;
            int gTemp = 0;
            int cWeight, cTemp;
            int counter = 0;

            while ((line = file.ReadLine()) != null)
            {
                string[] properties = line.Split(' ');
                if (counter == 0)
                {
                    gWeight = Convert.ToInt16(properties.ElementAt(0));
                    gTemp = Convert.ToInt16(properties.ElementAt(1));
                }
                else
                {
                    cWeight = Convert.ToInt16(properties.ElementAt(0));
                    cTemp = Convert.ToInt16(properties.ElementAt(1));

                    if (gWeight < cWeight && gTemp > cTemp)
                        Console.Write(counter + " ");
                }
                counter++;
            }
        }
    }
}
