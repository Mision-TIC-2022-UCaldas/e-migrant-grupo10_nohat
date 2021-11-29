using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace proyFinal_g63.Shared.Model 
{
    public class Movie
    {
        public int Id{get;set;}
        
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Name{get;set;}

        [Required(ErrorMessage = "Los {0} son requerido")]
        public string Apellido{get;set;}
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Tipo_Documento{get;set;}
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Numero_Documento{get;set;}
        [Required(ErrorMessage = "El {0} es requerido")]
        
        public string Pais_Origen{get;set;}
        [Required(ErrorMessage = "La {0} es requerida")]
        public string Fecha_Nacimiento{get;set;}
        public string Email{get;set;}
        public string Telefono{get;set;}
        public string Direccion{get;set;}
        public string Ciudad{get;set;}
        public string Situacion_Laboral{get;set;}




        public List<CategoryMovie> CategoriesMovie{get;set;}
    }
}
