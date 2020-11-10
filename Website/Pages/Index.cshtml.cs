using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
       
        /// <summary>
        /// the term for searching the menu
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// the list of items in the view
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// the list of categories of item in the view
        /// </summary>
        public string[] Category { get; set; }

        public void OnGet(string Searchterms, string[] Category, double? PriceMin, double? PriceMax, double? CalorieMin, double? CalorieMax)
        {
            //Category = Request.Query["Category"];
            this.Category = Category;            
            Items = Menu.Search(Searchterms);
            Items = Menu.FilterByCategory(Items, Category);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);

        }
    }
}
