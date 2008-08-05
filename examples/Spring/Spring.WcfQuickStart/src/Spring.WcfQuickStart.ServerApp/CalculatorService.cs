using System;
using System.Threading;
//using System.ServiceModel;

namespace Spring.WcfQuickStart
{
    //[ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class CalculatorService : ICalculator
    {
        private int sleepInSeconds;

        public int SleepInSeconds
        {
            get { return sleepInSeconds; }
            set { sleepInSeconds = value; }
        }

        public double Add(double n1, double n2)
        {
            Thread.Sleep(sleepInSeconds*1000);
            return n1 + n2;

        }

        public double Subtract(double n1, double n2)
        {
            Thread.Sleep(sleepInSeconds * 1000);
            return n1 - n2;

        }

        public double Multiply(double n1, double n2)
        {
            Thread.Sleep(sleepInSeconds * 1000);
            return n1 * n2;

        }

        public double Divide(double n1, double n2)
        {
            Thread.Sleep(sleepInSeconds * 1000);
            return n1 / n2;

        }

        public string GetName()
        {
            Thread.Sleep(sleepInSeconds * 1000);
            return "ServerApp Calculator";
        }
    }
}