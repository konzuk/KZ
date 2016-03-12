using Framework.Interfaces.Controller;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;

namespace Framework.Base.Helper
{
    public class KZHelperMessage : IKZHelperMessage
    {
        public string Create(string message)
        {
            return $"{Resource.translate.Create} {message}";
        }

        public string Update(string message)
        {
            return $"{Resource.translate.Update} {message}";
        }

        public string View(string message)
        {
            return $"{Resource.translate.View} {message}";
        }

        public string Delete(string message)
        {
            return $"{Resource.translate.Delete} {message}";
        }
    }
}