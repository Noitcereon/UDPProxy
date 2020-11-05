

using System.Collections.Generic;
using System.Linq;
using ModelLib;

namespace RestSensor.Managers
{
    public class SensorManager
    {
        private static readonly List<SensorData> SensorData = new List<SensorData>
        {
            new SensorData(GenerateId(),  )
        };
        public List<SensorData> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public SensorData GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public string AddData(SensorData newData)
        {
            throw new System.NotImplementedException();
        }

        private static int GenerateId()
        {
            return SensorData.Max(x => x.Id) + 1;
        }
    }
}
