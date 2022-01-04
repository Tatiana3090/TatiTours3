using System.ComponentModel.DataAnnotations;

namespace Tatitours3.Models
{
    public class Cliente
    {
        [Key]

        public int Id { get; set; }



        public string Nome { get; set; }



        public string CPF { get; set; }



        public string Email { get; set; }



        public int Cartao { get; set; }



        public int Numero_do_voo { get; set; }
    }
}
