using System.ComponentModel.DataAnnotations.Schema;

namespace MAPZebraPrinter.Models
{
    public class AliasNumber
    {
        public string? ItemNumber { get; set; }

        [Column("AliasNumber")]
        public string? AliasCode { get; set; }

        public string? Season { get; set; }
        public string? Company { get; set; }
    }
}
