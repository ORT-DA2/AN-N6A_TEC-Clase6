
using Contracts;

namespace PDFExport
{
    public class ExportHandler: IExport
    {
        public override string ToString()
        {
            return "I am the handler for PDF Export";
        }

        public void CreateFile(string filename)
        {
            throw new System.NotImplementedException();
        }

        public bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public void ExceuteExport()
        {
            throw new System.NotImplementedException();
        }
    }
}
