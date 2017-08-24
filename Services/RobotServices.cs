using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Roboots.Models;

namespace Roboots.Services
{
    public class RobotServices
    {
        public static List<RobotModel> Builder()
        {
            JsonSerializer serializer = new JsonSerializer();
            var botList = new List<RobotModel>();

            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var newBot = JsonConvert.DeserializeObject<RobotModel>(reader.ReadToEnd());
                botList.Add(newBot);
            }
            return botList;
        }
    }
}