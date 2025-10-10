using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Cliente
    {
        [Display(Name ="Id", Description = "Código")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public int Id { get; set; }
        [Display(Name="Nome Completo", Description ="Nome Do Cliente")]
        [Required(ErrorMessage = "Esse ca´mpo é obrigatório")]
        public string Nome { get; set; }
        [Display(Name ="Data de Nascimento", Description = "Nascimento do Cliente")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public DateOnly Nascimento { get; set; }
        [Display(Name = "Sexo", Description = "Sexo do Cliente"), MaxLength(1)]
        public string Sexo { get; set; }
        [Display(Name = "CPF", Description = "CPF do Cliente")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public decimal CPF { get; set; }
        [Display(Name = "Telefone", Description = "Telefone do Cliente")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public int Telefone { get; set; }
        [Display(Name = "E-Mail", Description = "E-mail do Cliente")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public string Email { get; set; }
        [Display(Name = "Senha", Description = "Senha do Cliente")]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public int Senha { get; set; }
        [Display(Name = "Situação", Description = "Situação do Cliente"), MaxLength(1)]
        [Required(ErrorMessage ="Esse ca´mpo é obrigatório")]
        public string Situacao { get; set; }


    }
}
