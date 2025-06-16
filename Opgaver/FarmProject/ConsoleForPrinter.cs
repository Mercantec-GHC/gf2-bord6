// Remove these using statements, as they are not supported in Blazor:
using System.Drawing;
using System.Drawing.Printing;

namespace FarmProject
{
    public class ConsoleForPrinter
    {
        private List<ADPrinterInfo> aDlabelInfos = new List<ADPrinterInfo>()
        {
            new ADPrinterInfo { Weight = "1kg", Size = "5cm", Color = "Black", Variety = "Apple" }
        };

        public void Add(ADPrinterInfo printerInfo)
        {
            foreach (var item in aDlabelInfos)
            {
                Console.WriteLine($"Weight: {item.Weight}, Size: {item.Size}, Color: {item.Color}, Variety: {item.Variety}");
                
            }
        }
    }

    public class ADPrinterInfo
    {
        public string Weight { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;

        public string PrinterName { get; set; } = "HP LaserJet P1005";
        public string item
        {
            get { return $"{Weight} {Size} {Color} {Variety}"; }
        }
    }
}
