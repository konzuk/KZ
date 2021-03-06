﻿using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class ContactMemberTypeModel : ModelBaseDecorator, IContactMemberTypeModel
    {
        private IContactTypeModel _contactTypeModel;

        public ContactMemberTypeModel(IUnityContainer container) : base(container)
        {
        }

        public int ContactTypeId
        {
            get { return ContactTypeModel == null ? 0 : ContactTypeModel.Id; }
        }

        public IContactTypeModel ContactTypeModel
        {
            get { return _contactTypeModel; }
            set
            {
                _contactTypeModel = value;
                RaisePropertyChanged("ContactTypeModel");
            }
        }

        public string ContactTypeName
        {
            get { return ContactTypeModel == null ? "" : ContactTypeModel.Name; }
        }
    }
}