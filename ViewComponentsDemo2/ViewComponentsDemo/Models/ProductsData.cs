using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentsDemo.Models
{
    public class ProductsData
    {
        private List<Product> _Products = new List<Product>
        {
            new Product{
                ProductID=1,
                ProductName="Apple iPhone 12",
                Quantity=100,
                UnitsInStock=50,
                Discontinue=false,
                Cost=3200,
                LaunchDate=new DateTime(2020,06,22)
            },
            new Product{
                ProductID=2,
                ProductName="Samsung Galaxy S20",
                Quantity=90,
                UnitsInStock=44,
                Discontinue=false,
                Cost=3150,
                LaunchDate=new DateTime(2020,01,15)
            },
            new Product{
                ProductID=3,
                ProductName="Apple iPhone 12 pro",
                Quantity=50,
                UnitsInStock=29,
                Discontinue=false,
                Cost=3200,
                LaunchDate=new DateTime(2020,06,22)
            },
            new Product{
                ProductID=4,
                ProductName="Oneplus 8 pro",
                Quantity=100,
                UnitsInStock=50,
                Discontinue=false,
                Cost=3200,
                LaunchDate=new DateTime(2019,11,06)
            }
        };
        public IEnumerable<Product> Products => _Products;
    }
}
