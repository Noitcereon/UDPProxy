using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;
using RestSensor.Managers;

namespace RestSensor.Controllers
{
    [ApiController]
    [Route("api/data/")]
    public class SensorController : ControllerBase
    {
        private static readonly SensorManager Manager = new SensorManager();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<SensorData> data = Manager.GetAll();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);            
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            SensorData data = Manager.GetOne(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddSensorData([FromBody] SensorData newData)
        {
            if (newData == null)
            {
                return BadRequest();
            }

            string response = Manager.AddData(newData);
            return Ok(response);
        }
    }
}
