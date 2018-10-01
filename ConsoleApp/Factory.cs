using System.ComponentModel;
using Contracts;

namespace ConsoleApp
{
    public enum ExportType
    {
        PDF,
        CSV
    }

    public class Factory
    {
        public static IExport GetExportHandler(ExportType type)
        {
            IExport result;

            switch (type)
            {
                case ExportType.PDF:
                    result = new PDFExport.ExportHandler();
                    break;
                case ExportType.CSV:
                    result = new CSVExport.ExportManager();
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            return result;
        }
    }
}
