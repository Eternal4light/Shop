using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }
        public string carCategory { get; set; }
    }
}
