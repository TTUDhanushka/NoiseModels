using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNoiseModels
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

}
