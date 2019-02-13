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

        static void Main(string[] args)
        {


            backGroundThread = new Thread(DoWork);

            backGroundThread.Start();
        }

        private static void DoWork()
        {
            GaussianNoise gaussianNoise = new GaussianNoise();



            while (true)
            {
                double gauss =  gaussianNoise.GenerateGaussianNoise();
            }
        }
    }
}
