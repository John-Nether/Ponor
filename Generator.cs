using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponor
{
    internal class Generator
    {
        public int min { get; set; }
        public int max { get; set; }
        public int step { get; set; }

        public Generator(int min, int max, int step)
        {

            this.min = min;
            this.max = max;
            this.step = step;

        }

        public double[,] GenDat()
        {
            Random ran = new Random();
            double[,] tmp = new double[2, step];
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < step; j++)
                {
                    tmp[i, j] = ran.NextDouble();
                }
            }
            return tmp;
        }
    }
}
