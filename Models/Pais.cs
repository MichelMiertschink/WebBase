using System.ComponentModel.DataAnnotations.Schema;

namespace WebBase.Models
{
    [Table("pais")]
    public class Pais :ModelBase
    {
        public string Nome { get; set; }
        public string? CodigoBacen { get; set; }
    }
}
