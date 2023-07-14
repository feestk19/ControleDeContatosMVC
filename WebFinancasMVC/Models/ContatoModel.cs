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
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Email do contato
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Celular do contato
        /// </summary>
        [Required]
        public string Celular { get; set; }
    }
}
