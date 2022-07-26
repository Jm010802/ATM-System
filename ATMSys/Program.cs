using System;

namespace ATMSys
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            app.Initialization();
            app.Execute();
        }
    }
}
