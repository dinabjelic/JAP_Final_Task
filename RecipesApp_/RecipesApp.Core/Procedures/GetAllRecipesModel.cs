using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Models.Procedures
{
    public class GetAllRecipesModel
    {
        public string RecipeName { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
    }
}
