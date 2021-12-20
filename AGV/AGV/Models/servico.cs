using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGV.Models
{
    [Table("Serviço")]
    public class Servico
    {
        
        [Column("ID Serviço")]
        [Key]
        public int Idservico { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        [Required(ErrorMessage = "Preencha a cidade!")]
        public string cidade { get; set; }

        [Display(Name = "Data da Ida")]
        [Column("Data da Ida")]
        [Required(ErrorMessage = "Preencha a data de ida!")]
        public DateTime dataIda { get; set; }

        [Display(Name = "Data da Volta")]
        [Column("Data da Volta")]
        [Required(ErrorMessage = "Preencha a data de volta!")]
        public DateTime dataVolta { get; set; }

        [Display(Name = "Quantidade de Passageiros")]
        [Column("Quantidade de Passageiros")]
        [Required(ErrorMessage = "Preencha a quantidade de passageiros!")]
        public int qtdPassageiros { get; set; }

        [Display(Name = "Preço")]
        [Column("Preço")]
        [Required(ErrorMessage = "Preencha o preço!")]
        public float preco { get; set; }

        public List<Usuario> UsuariosServico { get; set; } = new List<Usuario>();

            }
}

