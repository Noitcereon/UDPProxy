

using System.Collections.Generic;
using System.Linq;
using ModelLib;

namespace RestSensor.Managers
{
    public class SensorManager
    {
        private static readonly List<SensorData> SensorData = new List<SensorData>();
        public List<SensorData> GetAll()
        {
            return SensorData;
        }

        public SensorData GetOne(int id)
        {
            return SensorData.Find(x => x.Id == id);
        }

        public string AddData(SensorData newData)
        {
            newData.Id = GenerateId();
            SensorData.Add(newData);

            return $"Added {newData}";
        }

        private static int GenerateId()
        {
            int highestId = SensorData.Max((x) => x.Id);
            return highestId + 1;
        }
    }
}
