using System;
using System.Linq;
using Entity.Tables.Master.Contact;
using Framework.Base.App;
using Framework.Base.Controller;
using Framework.Base.Helper;
using Framework.Interfaces.Helper;
using MainInfrastructure.Controller;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;
using Repository;

namespace MainController.Contact
{
    public class ContactController : ControllerBase, IContactController
    {
        public ContactController(IUnityContainer container) : base(container)
        {
        }

        public KZResult<IContactModel> GetCustomers(IContactModel queryModel)
        {

            var result = new KZResult<IContactModel>();
            var models = new KZBindingList<IContactModel>();
            try
            {
                var adapter = KZHelper.Container.Resolve<IObjectContext>();

                var contactTypeMemberId = queryModel?.ContactMemberTypeModel?.Id ?? 0;
                var contactTypeId = queryModel?.ContactMemberTypeModel?.ContactTypeModel?.Id ?? 0;

                var ctRepo = new Repository<ContactTable>(adapter);

                var contactTables = ctRepo.FindNoTracking(s =>
                    (contactTypeId == 0 || s.ContactMemberTypeTable.ContactTypeId == contactTypeId) &&
                    (contactTypeMemberId == 0 || s.ContactMemberTypeId == contactTypeMemberId)
                    ).ToList();

                foreach (var ct in contactTables)
                {
                    var model = KZHelper.Container.Resolve<IContactModel>();

                    model.Id = ct.Id;
                    model.Name = ct.Name;

                    models.Add(model);
                }
            }
            catch (Exception ex)
            {
                result = new KZResult<IContactModel>()
                {
                    Message = new KZResultMessage()
                    {
                        IsSuccess = false,
                        Message = GetException(ex.Message),
                    },
                    
                    Models = new KZBindingList<IContactModel>()
                };

            }
            finally
            {
                result.Models = models;
            }

            return result;


        }
    }
}