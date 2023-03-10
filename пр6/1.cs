using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr6_1
{
    class Phone
    {
        public Phone (string model, string number)
        {
            Model = model;
            Number = number;
        }
        public string Model
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public void Call(string number)
        {
            Console.WriteLine($"Вызов по номеру {number}");
            WriteToLog($"Вызов {number}");
        }
        protected void WriteToLog(string text)
        {
            File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
        }
    }
    class Smartphone : Phone
    {
        public Smartphone (string model, string number, double cameraResolution) : base (model, number)
        {
            CameraResolution = cameraResolution;
        }
        public double CameraResolution
        {
            get;
            set;
        }
        public void Shoot()
        {
            Console.WriteLine("Снимок сделан");
            WriteToLog($"Снимок сделан");
        }
    }
    internal class Programa
    {
        static void Main(string[] args)
        {
            Phone HomePhone = new Phone("iPhone 11 pro max", "89085674534");
            HomePhone.Call("89065434523");
            Smartphone WorkPhone = new Smartphone("iPhone 14 pro max", "89543456789", 80.5);
            WorkPhone.Call("112");
            WorkPhone.Shoot();
            Console.ReadKey(true);
        }
    }
}
