using System.Collections.ObjectModel;
using Framework.Interfaces.Model.Common;
using Framework.Interfaces.Model.Employee;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Employee
{
    public class DepartmentModel : ModelBaseDecorator, IDepartmentModel
    {
        public DepartmentModel(IUnityContainer container) : base(container)
        {
        }


        public int ParentDepartmentId
        {
            get { return ParentDepartmentModel == null ? 0 : ParentDepartmentModel.Id; }
        }

        public IDepartmentModel ParentDepartmentModel { get; set; }
        public Collection<IDepartmentModel> ChildDepartmentModels { get; set; }

        public int CompanyId
        {
            get { return CompanyModel == null ? 0 : CompanyModel.Id; }
        }

        public ICompanyModel CompanyModel { get; set; }

        public string CompanyName
        {
            get { return CompanyModel == null ? "" : CompanyModel.Name; }
        }
    }
}