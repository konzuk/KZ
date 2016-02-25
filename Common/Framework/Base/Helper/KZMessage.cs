using Framework.Interfaces.Controller;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;

namespace Framework.Base.Helper
{
    public class KZMessage : IKZMessage
    {
        public IControllerBase Controller { get; set; }
        public IModelBase Model { get; set; }

        public IKZMessage CreateMessage(IControllerBase controller, IModelBase model)
        {
            return new KZMessage
            {
                Controller = controller,
                Model = model
            };
        }
    }
}