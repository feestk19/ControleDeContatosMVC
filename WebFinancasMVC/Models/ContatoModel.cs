using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        /// <summary>
        /// Id do contato
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do contato
        /// </summary>
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        /// <summary>
        /// Email do contato
        /// </summary>
        [Required(ErrorMessage = "Digite o email do contato")]
        [EmailAddress(ErrorMessage ="O Email informado é inválido!!")]
        public string Email { get; set; }

        /// <summary>
        /// Celular do contato
        /// </summary>
        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage ="O Celular informado não é válido!!")]
        public string Celular { get; set; }
    }
}
