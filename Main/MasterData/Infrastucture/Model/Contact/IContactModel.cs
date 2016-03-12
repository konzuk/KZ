using System;
using Framework.Interfaces.Model;

namespace MainInfrastructure.Model.Contact
{
    public interface IContactModel : IModelBase
    {
        string ContactNumber { get; set; }
        string Email { get; set; }
        string Note { get; set; }
        string PhotoPath { get; set; }
        int ContactMemberTypeId { get; }
        IContactMemberTypeModel ContactMemberTypeModel { get; set; }
        string ContactMemberTypeName { get; }
        int GenderId { get; }
        IGenderModel GenderModel { get; set; }
        string GenderName { get; }
        string ContactAddress { get; set; }
        string ContactAddressInLatin { get; set; }

        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }

        int Id { get; set; }
        string Name { get; set; }
        string NameInLatin { get; set; }
        string Code { get; set; }
    }
}