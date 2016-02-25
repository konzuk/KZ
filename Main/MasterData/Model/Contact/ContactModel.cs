using Framework.Interfaces.Model.Contact;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Contact
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


        public int ContactMemberTypeId
        {
            get { return ContactMemberTypeModel == null ? 0 : ContactMemberTypeModel.Id; }
        }

        public IContactMemberTypeModel ContactMemberTypeModel
        {
            get { return _contactMemberTypeModel; }
            set
            {
                _contactMemberTypeModel = value;
                RaisePropertyChanged(nameof(ContactMemberTypeModel));
            }
        }

        public string ContactMemberTypeName
        {
            get { return ContactMemberTypeModel == null ? "" : ContactMemberTypeModel.Name; }
        }

        public int GenderId
        {
            get { return GenderModel == null ? 0 : GenderModel.Id; }
        }

        public IGenderModel GenderModel
        {
            get { return _genderModel; }
            set
            {
                _genderModel = value;
                RaisePropertyChanged(nameof(GenderModel));
            }
        }

        public string GenderName { get; private set; }

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
    }
}