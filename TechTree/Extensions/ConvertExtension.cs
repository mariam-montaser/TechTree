using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechTree.Interfaces;
using System.Linq;

namespace TechTree.Extensions
{
    public static class ConvertExtension
    {
        public static List<SelectListItem> ConvertToSelectList<T>(this IEnumerable<T> collection, int selectedValue) where T : IPrimaryProperties
        {
            return (from item in collection
                    select new SelectListItem
                    {
                        Text = item.Title,
                        Value = item.Id.ToString(),
                        Selected = (item.Id == selectedValue)
                    }).ToList();
        }
    }
}
