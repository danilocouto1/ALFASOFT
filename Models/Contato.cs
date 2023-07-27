using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALFASOFT.Models
{
    [Table("Contato")]
    public class Contato
    {
        public Contato() {
            ID = 0;
            Nome = "";
            ContatoNumero = "";
            Email = "";
        }
        public Contato(int iD, string nome, string contatoNumero, string email)
        {
            ID = iD;
            Nome = nome;
            ContatoNumero = contatoNumero;
            Email = email;
        }

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
