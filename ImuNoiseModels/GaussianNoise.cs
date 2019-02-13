using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImuNoiseModels
{
    public class GaussianNoise
    {
        public double GenerateGaussianNoise()
        {
            Random rnd = new Random(1);

            double x1 = 1 - rnd.NextDouble();
            double x2 = 1 - rnd.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1) * Math.Cos(2.0 * Math.PI * x2));

            return y1;
        }
        
    }
}
