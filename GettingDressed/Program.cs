using GettingDressed.Rules;
using System;
using Ninject;
using Ninject.Modules;
namespace GettingDressed
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                executeHotTemperatureProcess();
                executeColdTemperatureProcess();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }

        private static void executeColdTemperatureProcess()
        {
            Console.WriteLine("Cold temperature processing start");
            Console.WriteLine();
            String temperatureType = string.Empty;
            String commandList = string.Empty;
            IRulesEngine iRules = new RulesEngine();
            Console.WriteLine("****SUCCESS****");
            temperatureType = "COLD";
            commandList = "8,6,3,4,2,5,1,7";
            Console.WriteLine(iRules.processRules(temperatureType, commandList));

            Console.WriteLine("****FAILURE****");
            temperatureType = "COLD";
            commandList = "8,6,3,4,2,5,7";
            Console.WriteLine(iRules.processRules(temperatureType, commandList));

            temperatureType = "COLD";
            commandList = "6";
            Console.WriteLine(iRules.processRules(temperatureType, commandList));
            Console.WriteLine("Cold temperature processing end");
            Console.WriteLine();
        }

        private static void executeHotTemperatureProcess()
        {
            Console.WriteLine();
            Console.WriteLine("Hot temperature processing start");
            String temperatureType = string.Empty;
            String commandList = string.Empty;

            IRulesEngine iRules = new RulesEngine();
            Console.WriteLine(iRules.processRules(temperatureType, commandList));

            Console.WriteLine("****SUCCESS****");
            temperatureType = "HOT"; 
            commandList = "8,6,4,2,1,7"; 

            Console.WriteLine(iRules.processRules(temperatureType, commandList));
            Console.WriteLine();

            Console.WriteLine("****FAILURE****");
            temperatureType = "HOT"; 
            commandList = "8,6,6"; 

            Console.WriteLine(iRules.processRules(temperatureType, commandList));

            temperatureType = "HOT"; 
            commandList = "8,6,3"; 
            Console.WriteLine(iRules.processRules(temperatureType, commandList));


            temperatureType = "HOT"; 
            commandList = "8,6,6,20"; 
            Console.WriteLine(iRules.processRules(temperatureType, commandList));


            temperatureType = "HOT"; 
            commandList = "8,6,4,3,5,2,1,7"; 
            Console.WriteLine(iRules.processRules(temperatureType, commandList));
            Console.WriteLine("Hot temperature processing end");
            Console.WriteLine();
        }
    }
}
