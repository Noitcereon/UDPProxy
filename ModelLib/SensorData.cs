using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ModelLib
{
    public class SensorData
    {
        
        public int Id { get; set; }
        public string SensorName { get; set; }
        public double Temperature { get; set; }
        public double CO2 { get; set; }

        public SensorData()
        {
            
        }
        public SensorData(string name, double temperature, double co2)
        {
            SensorName = name;
            Temperature = temperature;
            CO2 = co2;
        }

        public override string ToString()
        {
            return $"Sensor data: {Id}, {SensorName}, {Temperature}, {CO2}";
        }
    }
}
