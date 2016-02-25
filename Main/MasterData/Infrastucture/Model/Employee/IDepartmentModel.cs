using System.Collections.ObjectModel;
using Framework.Interfaces.Model;
using MainInfrastructure.Model.Common;

namespace MainInfrastructure.Model.Employee
{
    public interface IDepartmentModel : IModelBase
    {
        int ParentDepartmentId { get; }
        IDepartmentModel ParentDepartmentModel { get; set; }
        Collection<IDepartmentModel> ChildDepartmentModels { get; set; }

        int CompanyId { get; }
        ICompanyModel CompanyModel { get; set; }
        string CompanyName { get; }
    }
}