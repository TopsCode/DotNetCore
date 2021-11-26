using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Components
{
    public class ProductSummary : ViewComponent
    {
        private ProductsData data;
        public ProductSummary(ProductsData pdata)
        {
            data = pdata;
        }

        //public string Invoke()
        //{
        //    return $"{data.Products.Count()} Products, " + $"{data.Products.Sum(c => c.Cost)} Worth of stock";
        //}

        // 3.
        //public IViewComponentResult Invoke(int units)
        //{
        //    return View(new ProductViewModel
        //    {
        //        ProductsCount = data.Products.Count(),
        //        StockWorth = data.Products.Sum(c => c.Cost)
        //    });
        //}

        // 4. passing parameters to view components
        public IViewComponentResult Invoke(int units)
        {
            return View(new ProductViewModel
            {
                ProductsCount = data.Products.Where(x => x.UnitsInStock >= units).Count(),
                StockWorth = data.Products.Where(x => x.UnitsInStock >= units).Sum(c => c.Cost)
            });
        }
    }
}
