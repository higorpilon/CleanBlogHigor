using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CleanBlogHigor.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Por favor insira o seu nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor insira o seu email")]
        [EmailAddress(ErrorMessage = "Por favor insira um email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor insira a sua mensagem")]
        [MaxLength(500,ErrorMessage ="Máximo de 500 caracteres")]
        public string Message { get; set; }


        public int ContactFormId { get; set; }
    }
}