using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCar = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla",
                        ShortDescription = "Тачка илона маска",
                        LongDescription ="крутой автомобиль тесла, имеет четыре колсеса и много других деталей",
                        Img ="/images/Tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = _categoryCar.AllCategories.Last() 
                    },
                    new Car {
                        Name = "Audi",
                        ShortDescription = "немецкая тачка",
                        LongDescription ="крутой автомобиль ауди, имеет четыре колсеса и много других деталей",
                        Img ="/images/Audi.jpg",
                        Price = 45000,
                        IsFavorite = false,
                        Available = true,
                        Category = _categoryCar.AllCategories.First()
                    },
                    new Car {
                        Name = "Volvo",
                        ShortDescription = "безопасная тачка",
                        LongDescription ="крутой автомобиль вольво, имеет четыре колсеса и много других деталей",
                        Img ="/images/Volvo.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = false,
                        Category = _categoryCar.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavoriteCars
        {
            get
            {
                return Cars.Where(c => c.IsFavorite == true);
            }
        }

        public Car GetObjectCar(int carId)
        {
            return Cars.Where(c => c.Id == carId).First();
        }
    }
}
