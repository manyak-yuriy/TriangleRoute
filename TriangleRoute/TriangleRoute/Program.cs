using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleRoute
{
    class Program
    {
   
        static double[][] getMap(string fileName, out int mapSize)
        {
            var lines = File.ReadAllLines(fileName);

            mapSize = lines.Length;
            double[][] map = new double[mapSize][];

            for (int i = 0; i < mapSize; i++)
            {
                map[i] = new double[i + 2];
                map[i][0] = double.NegativeInfinity;
                string[] lineElem = lines[i].Split(' ');
                if (lineElem.Length != i + 1)
                    throw new Exception(String.Format("Line #{0} must contain {1} elements", i + 1, i + 1));
                for (int j = 1; j < i + 2; j++)
                    map[i][j] = double.Parse(lineElem[j - 1]);
            }
            return map;
        }


        static void Main(string[] args)
        {
            if (args.Length == 0)
                throw new Exception("File name not specified as command line parameter");

            string fileName = args[0];
            int mapSize;
        
            double[][] map = getMap(fileName, out mapSize);



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
