using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
                
        }
        public Car(int year, string make, string model, bool isDriveable, string engineNoise, string honkNoise) 
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void SetEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
        }

        public void SetHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
        }
    }
}


//Year, Make, Model, EngineNoise, HonkNoise, IsDriveable