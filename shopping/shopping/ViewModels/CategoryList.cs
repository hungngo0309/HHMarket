using System;
using shopping.Models;
using System.Collections.Generic;
namespace shopping.ViewModels
{
    public class CategoryList
    {
        public Category MainCategoryInfo;
        public List<Category> subCategory;
        public CategoryList()
        {
        }
    }
}
