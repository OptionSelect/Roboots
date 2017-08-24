using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Roboots.Models;
using Roboots.Services;

namespace Roboots.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index(int ID)
        {
            var robotList = RobotServices.Builder();

            return View(robotList[ID-1]); 
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
