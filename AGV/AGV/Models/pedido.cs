using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AGV.Models
{
   [Table("Pedido")]
   
   public class Pedido
        {
            [Key]
            
            [Column("ID PEDIDO")]
            public int IdPedido { get; set; }      
        
            [Display(Name = "Tipo de Pagamento")]
            [Column("Tipo de Pagamento")]
            [Required(ErrorMessage = "Preencha o tipo de Pagamento. Ex: À Vista!")]
            public string tipoPagamento { get; set; }

            [Display(Name = "Cupom de Desconto")]
            [Column("Cupom de Desconto")]
            public string cupomDesconto { get; set; }

            [Display(Name = "Promoção")]
            [Column("Promoção")]
            public int promocao { get; set; }


        } 

}
    
    
    
