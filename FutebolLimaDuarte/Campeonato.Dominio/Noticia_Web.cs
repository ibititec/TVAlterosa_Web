using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Campeonato.Dominio
{
    public class Noticia_Web
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }

        [Display(Name = "Notícia")]
        [Required(ErrorMessage = "O campo Notícia é obrigatório.")]
        public String Noticia { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNoticia { get; set; }

        [HiddenInput(DisplayValue = false)]
        public String DataNoticiaString
        {
            get 
            {
                if (this.DataNoticia == null)
                    return "";
                else
                {
                    DateTime data = Convert.ToDateTime(this.DataNoticia);
                    return data.ToString("dd/MM/yyyy"); 
                }
                
            }
        }
      
       
    }
}
