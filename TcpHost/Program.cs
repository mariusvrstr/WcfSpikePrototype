﻿
namespace Spikes.TcpHost
{
    using System;
    using System.ServiceModel;

    public class Program
    {
        static void Main(string[] args)
        {
            var manager = new ServiceManager();

            try
            {
                manager.OpenAll();

                Console.WriteLine("Services is available over SOAP (TCP). " +
                  "Press <ENTER> to exit.");
                Console.ReadLine();
                manager.CloseAll();
            }
            catch (CommunicationException commProblem)
            {
                Console.WriteLine("There was a communication problem. " + commProblem.Message);
                Console.Read();
            }
        }
    }
}
