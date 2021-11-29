using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace proyFinal_g63.Shared.Model 
{
    public class Category{
        
        public int Id{get;set;}
        //@* [Required(ErrorMessage = "El {0} es requerido")] *@
        public string Name{get;set;}





        public List<CategoryMovie> CategoriesMovie{get;set;}


    }
}
