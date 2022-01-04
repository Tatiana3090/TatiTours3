using System.ComponentModel.DataAnnotations;

namespace Tatitours3.Models
{
    public class Contato
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }


    }
}
