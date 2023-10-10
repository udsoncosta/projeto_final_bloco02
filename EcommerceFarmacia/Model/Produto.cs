using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EcommerceFarmacia.Model;

namespace EcommerceFarmacia.Model
{
    public class Produto
    {
        [Key] //Primary Key (Id)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // IDENTITY(1,1)
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(2000)]
        public string Descricao { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateOnly DataValidade { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Preco { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(5000)]
        public string Foto { get; set; } = string.Empty;


        public virtual Categoria? Categoria { get; set; }


    }
}