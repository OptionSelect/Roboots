using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Roboots.Models;
using System.Linq;

namespace Roboots.Services
{
    public class RobotServices
    {
        public static List<RobotModel> Builder()
        {
            using (var reader = new StreamReader(System.IO.File.Open("database.json", FileMode.Open)))
            {
                var botList = JsonConvert.DeserializeObject<List<RobotModel>>(reader.ReadToEnd());                
                return botList;
            }   
        }
    }
}