
namespace Contracts
{
    public interface IExport
    {
        void CreateFile(string filename);

        bool IsValid();

        void ExceuteExport();
    }
}
