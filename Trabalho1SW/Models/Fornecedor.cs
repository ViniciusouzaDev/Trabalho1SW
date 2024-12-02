using System.ComponentModel.DataAnnotations;

namespace Trabalho1SW.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Este endereço de e-mail não é válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "CNPJ")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "O CNPJ inserido não é válido. Utilize o formato 00.000.000/0000-00.")]
        public string cnpj { get; set; }

        [Required]
        [Phone(ErrorMessage = "Este telefone não é válido")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP inserido não é válido. Utilize o formato 00000-000.")]
        public string cep { get; set; }

        [Required]
        [Display(Name = "Nome da pessoa de contato")]
        public string PessoaContato { get; set; }

        [Required]
        [Display(Name = "Rua")]
        public string rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required]
        [Display(Name = "País")]
        public string Pais { get; set; }

    }
}
