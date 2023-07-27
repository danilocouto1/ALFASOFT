using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALFASOFT.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Required]
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 6)]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        [Column("ContatoNumero")]
        public string ContatoNumero { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email")]
        public string Email { get; set; }
    }
}
