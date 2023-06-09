﻿using Microsoft.AspNetCore.Mvc;
using RandomPokemon.Models;
using System.Diagnostics;

namespace RandomPokemon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        PokemonDAL pokeAPI = new PokemonDAL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet] //<- this specifies what type of call an action makes to your server 
        //by default all method are gets, but later you may use this tag for setting endpoint on your own created api 
        //More on this tomorrow
        public IActionResult Index()
        {
            Pokemon p = pokeAPI.GetRandomPokemon();
            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}