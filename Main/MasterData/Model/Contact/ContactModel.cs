using System;
using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class ContactModel : ModelBaseDecorator, IContactModel
    {
        private string _contactAddress;

        private string _contactAddressInLatin;
        private IContactMemberTypeModel _contactMemberTypeModel;

        private string _contactNumber;

        private string _email;
        private IGenderModel _genderModel;

        private string _note;

        private DateTime _dateOfBirth;
        private string _placeOfBirth;


        public ContactModel(IUnityContainer container) : base(container)
        {
        }

        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
                RaisePropertyChanged(nameof(ContactNumber));
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                RaisePropertyChanged(nameof(Note));
            }
        }

        public string PhotoPath { get; set; }


        public int ContactMemberTypeId => ContactMemberTypeModel?.Id ?? 0;

        public IContactMemberTypeModel ContactMemberTypeModel
        {
            get { return _contactMemberTypeModel; }
            set
            {
                _contactMemberTypeModel = value;
                RaisePropertyChanged(nameof(ContactMemberTypeModel));
            }
        }

        public string ContactMemberTypeName => ContactMemberTypeModel == null ? "" : ContactMemberTypeModel.Name;

        public int GenderId => GenderModel?.Id ?? 0;

        public IGenderModel GenderModel
        {
            get { return _genderModel; }
            set
            {
                _genderModel = value;
                RaisePropertyChanged(nameof(GenderModel));
            }
        }

        public string GenderName => GenderModel == null ? "" : GenderModel.Name;

        public string ContactAddress
        {
            get { return _contactAddress; }
            set
            {
                _contactAddress = value;
                RaisePropertyChanged(nameof(ContactAddress));
            }
        }

        public string ContactAddressInLatin
        {
            get { return _contactAddressInLatin; }
            set
            {
                _contactAddressInLatin = value;
                RaisePropertyChanged(nameof(ContactAddressInLatin));
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value; 
                RaisePropertyChanged(nameof(DateOfBirth));
            }
        }

        public string PlaceOfBirth
        {
            get { return _placeOfBirth; }
            set
            {
                _placeOfBirth = value;
                RaisePropertyChanged(nameof(PlaceOfBirth));
            }
        }
    }
}