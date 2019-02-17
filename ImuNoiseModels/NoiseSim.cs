using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImuNoiseModels
{
    public class AccelerometerSim
    {
        const int Seconds = 60;

        public double GenerateGaussianNoise(Random rand, double mean, double variance)
        {
            //Random rnd = new Random(1);

            double x1 = 1 - rand.NextDouble();
            double x2 = 1 - rand.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1) * Math.Cos(2.0 * Math.PI * x2));

            return y1;
        }

        public double GetEngineNoise(double rpm)
        {
            double frequency = rpm / Seconds;


            return frequency;
        }



    }

    public class GyroSim
    {
        public double GenerateGaussianNoise(Random rand, double mean, double variance)
        {
            //Random rnd = new Random(1);

            double x1 = 1 - rand.NextDouble();
            double x2 = 1 - rand.NextDouble();

            // Box - Muller method
            double r = Math.Sqrt(-2.0 * Math.Log(x1));
            double theta = 2.0 * Math.PI * x2;

            double x = r * Math.Cos(theta);
            //double y1 = Math.Sqrt(-2.0 * Math.Log(x1) * Math.Cos(2.0 * Math.PI * x2));

            return x;
        }
    }

    public class Utilities
    {
        public double FFT(short dir, int m, double[] x, double[] y)
        {
            double timeDomain = 0.0;

            return timeDomain;
        }
    }
}
