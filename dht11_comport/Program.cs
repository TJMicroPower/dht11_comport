using System;
using System.IO.Ports;

namespace dht11_comport
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////// KONSOL AYARLARI ///////////////////////////////////
            Console.SetWindowSize(70, 30);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            /////////////////////////////////////////////////////////////////
            
            
            /////////////////////////////////////////////////////////////////
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            myport.Open();
            /////////////////////////////////////////////////////////////////


            /////////////////////////////////////////////////////////////////
            bool devametsinmi = true;
            while (devametsinmi && true)
            {
                string data_rx = myport.ReadLine();
                Console.WriteLine(data_rx);
            }
            /////////////////////////////////////////////////////////////////
        }
    }
}