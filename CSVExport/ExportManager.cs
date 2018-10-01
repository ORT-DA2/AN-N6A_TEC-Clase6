using System;
using System.Runtime.CompilerServices;
using Contracts;

namespace CSVExport
{
    public class ExportManager : IExport
    {
        public ExportManager()
        {
            this.Author = "No name";
        }

        public ExportManager(string author)
        {
            this.Author = author;
        }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"I am the handler for CSV Export, the file author will be {this.Author}";
        }

        public void CreateFile(string filename)
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(this.Author);
        }

        public void ExceuteExport()
        {
            throw new NotImplementedException();
        }

        private bool IsThisPrivateMethodVisible(string anyString)
        {
            return true;
        }
    }
}
