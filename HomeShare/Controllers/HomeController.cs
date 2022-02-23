using HoliDayRental.BLL.Services.Interfaces;
using HoliDayRental.Infrastructure.Helpers;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        private IBienEchangeService _bienService;
        public HomeController(ILogger<HomeController> logger, IBienEchangeService bienService )
        {
            _logger = logger;  
            _bienService= bienService;
        }

        public IActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel(_bienService);
           
            return View(hm);

        }        

    }
}
