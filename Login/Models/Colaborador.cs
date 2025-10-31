using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Login.Models
{
    public class Colaborador
    {
   
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public String CPF { get; set; }
        public string Email { get; set; }
       
        public string Senha { get; set; }

        [Display(Name = "Situação", Description = "Tipo do Colaborador"), MaxLength(1)]
        public string Tipo { get; set; }
    }
}
