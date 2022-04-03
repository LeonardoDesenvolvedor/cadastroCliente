using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Models
{
    public class Cliente
    {
        [Key]
        public  long ClienteId { get; set; }
        
         [Column ("Nome_cli")]
         [Required]
         [MaxLength(60)]
        public string Nome { get; set; }

        [Column ("Telefone_cli")]
        [Required]
        public string Telefone { get; set; }

        [Column("Email_cli")]
        [Required]
        [MaxLength(50)]
        public string Emai { get; set; }
  
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
