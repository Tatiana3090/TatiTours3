using System.ComponentModel.DataAnnotations;

namespace Tatitours3.Models
{
    public class Pacote
    {
        [Key]

        public int Id { get; set; }

        public string Promocoes { get; set; }

        public decimal Valor { get; set; }
    }
}
