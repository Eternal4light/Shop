using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult ListProducts()
        {
            ViewBag.Title = "Страница с автомобилями";
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.GetAllCars = _allCars.Cars;
            obj.carCategory = "Автомобили";
            //var cars = _allCars.Cars;
            return View(obj);
        }
    }
}
