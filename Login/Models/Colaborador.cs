using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Colaborador
    {
        [Display(Name = "Id", Description = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome Completo", Description = "Nome Do Colaborador")]
        public int Telefone { get; set; }
        [Display(Name = "E-Mail", Description = "E-mail do Colaborador")]
        public string Email { get; set; }
        [Display(Name = "Senha", Description = "Senha do Colaborador")]
        public int Senha { get; set; }
        [Display(Name = "Situação", Description = "Tipo do Colaborador"), MaxLength(1)]
        public string Tipo { get; set; }
    }
}
