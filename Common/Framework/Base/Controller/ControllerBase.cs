using System;
using Framework.Interfaces.Controller;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace Framework.Base.Controller
{
    public class ControllerBase : IControllerBase
    {
        private string keyException;
        protected Exception SetException(string message)
        {
            return new Exception(string.Format("{0}{1}",keyException, message));
           
        }
        protected string GetException(string message)
        {
            if (message.StartsWith(keyException))
            {
                return message;
            }
            else
            {
                return message.Replace(keyException, "");
            }
            

        }
        protected IKZHelper KZHelper { get; set; }
        public ControllerBase(IUnityContainer container)
        {
            keyException = "KzEx123";
            KZHelper = container.Resolve<IKZHelper>();
        }
    }
}