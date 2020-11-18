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

        /// <summary>
        /// min value of price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Max value of price
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// min value of Calories
        /// </summary>
        public double? CalorieMin { get; set; }

        /// <summary>
        /// min value of price
        /// </summary>
        public double? CalorieMax { get; set; }

        

        public void OnGet(string SearchTerms, string[] Category, double? PriceMin, double? PriceMax, double? CalorieMin, double? CalorieMax)
        {

            this.Category = Category;
            this.SearchTerms = SearchTerms;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;

            Items = Menu.ALL;
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) ||
                    item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            //filter the category             
            if (Category != null && Category.Length != 0)
            {
                Items = Items.Where(item => Category.Contains(item.Category));
            }

            //filter by price
            if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax
                    && item.Price >= PriceMin);
            }
            else if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            else if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }

            //filter by Calorie
            if (CalorieMax != null && CalorieMin != null)
            {
                Items = Items.Where(item => item.Calories <= CalorieMax
                    && item.Calories >= CalorieMin);
            }
            else if (CalorieMax == null && CalorieMin != null)
            {
                Items = Items.Where(item => item.Calories >= CalorieMin);
            }
            else if (CalorieMin == null && CalorieMax != null)
            {
                Items = Items.Where(item => item.Calories <= CalorieMax);
            }

            ////Category = Request.Query["Category"];
            //this.Category = Category;            
            //Items = Menu.Search(Searchterms);
            //Items = Menu.FilterByCategory(Items, Category);
            //Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            //Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);

        }
    }
}
