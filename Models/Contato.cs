using System.ComponentModel.DataAnnotations;

namespace ALFASOFT.Models
{
    public class Contato
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 6)]
        public string Nome { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string ContatoNumero { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
