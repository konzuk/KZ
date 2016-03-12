using Framework.Interfaces.Controller;
using Framework.Interfaces.Model;

namespace Framework.Interfaces.Helper
{
    public interface IKZHelperMessage
    {
        string Create(string message);
        string Update(string message);
        string View(string message);
        string Delete(string message);
    }
}