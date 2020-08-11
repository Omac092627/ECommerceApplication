﻿using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce_Application.Models;
using ECommerce_Application.Models.DTO;
using ECommerce_Application.Models.Interfaces;
using ECommerce_Application.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_Application.Controllers
{
    public class ProductsController : Controller
    {
        private  ICereal _cereal;

        public ProductsController(ICereal cereal)
        {
            _cereal = cereal;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CerealDTO> cereal = _cereal.GetCereal().Cast<CerealDTO>().ToList();
            return View(cereal);
        }

        public IActionResult Index(string searchString)
        {
            List<CerealDTO> cereals = _cereal.GetCereal().Cast<CerealDTO>().ToList();
            var results = cereals.Where(x => x.Name.Contains(searchString));


            return View(results);
        }

    }
}