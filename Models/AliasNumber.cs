namespace MAPZebraPrinter.Models
{
    public class AliasNumber
    {
        public string? ItemNumber { get; set; }
        private string? aliasNumber;

        public string? GetAliasNumber()
        {
            return aliasNumber;
        }

        public void SetAliasNumber(string? value)
        {
            aliasNumber = value;
        }

        public string? Season { get; set; }
        public string? Company { get; set; }
    }
}
