using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBOjects
    {
        private static Dictionary<string, Category> _category;

        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla",
                        ShortDescription = "Тачка илона маска",
                        LongDescription = "крутой автомобиль тесла, имеет четыре колсеса и много других деталей",
                        Img = "/images/Tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Audi",
                        ShortDescription = "немецкая тачка",
                        LongDescription = "крутой автомобиль ауди, имеет четыре колсеса и много других деталей",
                        Img = "/images/Audi.jpg",
                        Price = 45000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Volvo",
                        ShortDescription = "безопасная тачка",
                        LongDescription = "крутой автомобиль вольво, имеет четыре колсеса и много других деталей",
                        Img = "/images/Volvo.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    }
                );

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(_category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                        new Category {CategoryName = "Классические автомобили", Description = "Автомобили с ДВС"}
                    };

                    _category = new Dictionary<string, Category>();

                    foreach(Category el in list)
                    {
                        _category.Add(el.CategoryName, el);
                    }
                }

                return _category;
            }
        }
    }
}
