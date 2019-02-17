using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImuNoiseModels;

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
            AccelerometerSim accNoiseSim = new AccelerometerSim();
            GyroSim gyroNoiseSim = new GyroSim();

            Random rnd = new Random();


            while (true)
            {
                double gauss =  accNoiseSim.GenerateGaussianNoise(rnd, 0, 0.5);
            }
        }
    }
}
