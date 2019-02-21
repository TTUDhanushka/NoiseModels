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
        const double g = 9.80665;       // ms-2

        public enum Axes
        {
            Single,
            TriAxes
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

        public bool X_Enable { get; set; }

        public bool Y_Enable { get; set; }

        public bool Z_Enable { get; set; }

        public SensorOutput GaussianNoise { get; set; }

        public double AddGaussianNoise(Random rand, double mean, double variance)
        {
            //Random rnd = new Random(1);

            double x1 = 1 - rand.NextDouble();
            double x2 = 1 - rand.NextDouble();

            double y1 = Math.Sqrt(-2.0 * Math.Log(x1) * Math.Cos(2.0 * Math.PI * x2));

            return y1;
        }

        public double AddEngineNoise(double rpm)
        {
            double frequency = rpm / Seconds;


            return frequency;
        }

        public double AddGravityEffect()
        {
            double x = 0.0;

            return x;
        }

        public double GenerateNoisyOutput(Random r, double stDev, double mean)
        {
            double noiseOut = 0.0;

            //Random r = new Random();

            if (GaussianNoise == SensorOutput.Enabled)
                noiseOut += AddGaussianNoise(r, mean, stDev);


            return noiseOut;
        }

    }
}
