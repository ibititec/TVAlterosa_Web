﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Campeonato.Dominio
{
    public class Artilharia_Web
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Jogador")]
        [UIHint("GridForeignKey")]
        [Required(ErrorMessage = "O campo Jogador é obrigatório.")]
        public int Id_Jogador { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Id_Time { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Id_Campeonato { get; set; }

       public String NumeroGols { get; set; }
    }
}
