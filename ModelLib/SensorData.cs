using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class SensorData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Temperature { get; set; }
        public double CO2 { get; set; }

        public SensorData()
        {
            
        }

        public SensorData(int id, string name, double temperature, double co2)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            CO2 = co2;
        }

        public override string ToString()
        {
            return $"Sensor data: {Id}, {Name} {Temperature} {CO2}";
        }
    }
}
