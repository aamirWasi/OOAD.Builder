using System;

namespace OOD.dotnetBuildertuts
{
    public class ClientConsoleLogger : IClientConsoleLogger
    {
        public void Write(string message, string messageType)
        {
            Console.WriteLine($"{messageType} : {message}");
        }
    }
}
