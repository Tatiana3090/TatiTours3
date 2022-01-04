using System.ComponentModel.DataAnnotations;

namespace Tatitours3.Models
{
    public class Cidade
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Pontos_Turisticos { get; set; }
    }
}
