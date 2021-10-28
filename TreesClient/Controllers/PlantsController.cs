using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TreesClient.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TreesClient.Controllers
{

  public class PlantsController : Controller
  {
    
    public IActionResult Index()
    {
      var allPlants = Plant.GetPlants();
      return View(allPlants);
    }
  }
}