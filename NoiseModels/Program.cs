using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SensorNoiseModels;

namespace NoiseModels
{
    class Program
    {
        private static Thread backGroundThread;

        //const int NO_OF_POINTS = 50;
        //const int _seed = 0;
        //static double[] rndArray = new double[NO_OF_POINTS];

        static void Main(string[] args)
        {
            //// Generate few random numbers 
            //Random randomNum = new Random(_seed);

            //for(int i = 0; i < NO_OF_POINTS; i++)
            //{
            //    rndArray[i] = randomNum.NextDouble();
            //}

            backGroundThread = new Thread(DoWork);

            backGroundThread.Start();
        }

        private static void DoWork()
        {
            AccelerometerSim accel1 = new AccelerometerSim();
            GyroSim gyroNoiseSim = new GyroSim();

            Random rnd = new Random();

            accel1.NoOfAxes = AccelerometerSim.Axes.TriAxes;
            accel1.X_Enable = true;

            gyroNoiseSim.NoOfAxes = GyroSim.Axes.Single;

            accel1.GaussianNoise = AccelerometerSim.SensorOutput.Enabled;

            while (true)
            {
                //double gauss =  accNoiseSim.AddGaussianNoise(rnd, 0, 0.5);

                double accNoise = accel1.GenerateNoisyOutput(rnd, 0, 0.5);

                Console.WriteLine("Noisy out: {0}", accNoise.ToString("F2"));
            }
        }
    }
}
