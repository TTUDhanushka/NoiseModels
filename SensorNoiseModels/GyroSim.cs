using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNoiseModels
{
    public class GyroSim
    {
        public enum Axes
        {
            Single,
            Tri
        }

        public enum SensorOutput
        {
            Disabled,
            Enabled
        }

        public double Resolution { get; set; }

        public double Range { get; set; }

        public double StdDev { get; set; }

        public double Mean { get; set; }

        public Axes NoOfAxes { get; set; }

        public SensorOutput X { get; set; }

        public SensorOutput Y { get; set; }

        public SensorOutput Z { get; set; }

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
}
