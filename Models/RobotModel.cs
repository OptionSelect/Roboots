using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Roboots.Models
{
    public class RobotModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; }
        public string Phone { get; set; }
        public Dictionary<string, string> Address { get; set; }
    }
}