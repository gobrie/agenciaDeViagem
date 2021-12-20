using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGV.Models
{
        [Table("Usuário")]
        public class Usuario
        {
            
            [Column("ID Usuario")]
            [Key]
            public int Idusuario { get; set; }

            [Display(Name = "CPF")]
            [Column("CPF")]
            [Required(ErrorMessage ="Preencha o CPF!")]
            public string cpf { get; set; }

            [Display(Name = "Nome")]
            [Column("Nome")]
            [Required(ErrorMessage ="Preencha o nome!")]
            public string nome { get; set; }

            [Display(Name = "Email")]
            [Column("Email")]
            [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
            public string email { get; set; }

            [Display(Name = "Endereço")]
            [Column("Endereço")]
            [Required(ErrorMessage ="Preencha o endereço!")]
            public string endereco { get; set; }

        }


}
    