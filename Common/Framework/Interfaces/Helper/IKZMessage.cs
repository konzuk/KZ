using Framework.Interfaces.Controller;
using Framework.Interfaces.Model;

namespace Framework.Interfaces.Helper
{
    public interface IKZMessage
    {
        IControllerBase Controller { get; set; }
        IModelBase Model { get; set; }
        IKZMessage CreateMessage(IControllerBase controller, IModelBase model);
    }
}