using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Models
{
    public class Endereco
    {
        [Key]
        public long? EnderecoId { get; set; } 

        public long? ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(22)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("Rua", TypeName = "text")]
        public string Rua { get; set; }

        [Column("Numero_Residencia")]
        [Required]
        [MaxLength(5)]
        public string Numero { get; set; }


    }
}
