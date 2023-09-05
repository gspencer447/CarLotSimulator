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
        public Car(int year, string make, string model, bool isDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
        }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise(string newEngineNoise)
        {
            EngineNoise = newEngineNoise;
            return EngineNoise;
        }

        public string MakeHonkNoise(string newHonkNoise)
        {
            HonkNoise = newHonkNoise;
            return HonkNoise;
        }
    }
}


//Year, Make, Model, EngineNoise, HonkNoise, IsDriveable