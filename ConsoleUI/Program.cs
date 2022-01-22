using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:log4net.Config.XmlConfigurator(Watch =true)]

namespace ConsoleUI
{
    internal class Program
    {
        // Which gets the current class
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");

            //log.Error("This is my error message");

            // Levels - Debug is the lowest and fatal is the highest
            log.Debug("Developer : Tutorial was run");
            log.Info("Maintenance : water pump turned on");
            log.Warn("Maintenance : the water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Developer : we tried to divide by zero again");
            }


            for(int j = 0; j < 5; j++)
            {
                //log.Fatal("This is message number " + j.ToString());
                log4net.GlobalContext.Properties["Counter"] = j;
                log.Fatal("This is a fatal error in the process");
            }
            // log.Fatal("Maintenance : water pump exploded");
            log.Fatal("Second way");
            Counter k = new Counter();
            log4net.GlobalContext.Properties["Counter"] = k;

            for (k.LoopCounter = 0; k.LoopCounter < 5; k.LoopCounter++)
            {
                log.Fatal("This is a fatal error in the process LoopCounter");
            }
            Console.ReadLine();

        }
    }
}
