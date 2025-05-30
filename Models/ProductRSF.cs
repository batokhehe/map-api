using Microsoft.EntityFrameworkCore;

namespace MAPZebraPrinter.Models
{
    [Keyless]
    public class ProductRSF
    {
        public string? ItemNumber { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? StyleNo { get; set; }
        public string? ConfigurationCode { get; set; }
        public string? DimensionX { get; set; }
        public string? DimensionYOptionID { get; set; }
        public string? ItemGroup { get; set; }
        public string? FreeField4 { get; set; }
        public string? Company { get; set; }
    }
}
