using Framework.Interfaces.Model;

namespace MainInfrastructure.Model.Contact
{
    public interface IContactMemberTypeModel : IModelBase
    {
        int ContactTypeId { get; }
        IContactTypeModel ContactTypeModel { get; }
        string ContactTypeName { get; }
    }
}