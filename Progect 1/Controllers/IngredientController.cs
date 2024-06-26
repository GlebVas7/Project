﻿using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class IngredientController : Controller
    {

        private readonly IIngredientModel _manager;
        public IngredientController(IIngredientModel manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var ingridient = await _manager.GetAllIngredients();
            return View(ingridient);
        }
        [HttpGet]
        [Route("ingridient")]
        public async Task<IList<Ingredient>> GetAll() => await _manager.GetAllIngredients();

        
    }
}
