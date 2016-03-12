using System;
using MainInfrastructure.Model.Employee;
using MainModel.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Employee
{
    public class EmployeeModel : ContactModel, IEmployeeModel
    {
        public EmployeeModel(IUnityContainer container) : base(container)
        {
        }

        public int PositionId => PositionModel?.Id ?? 0;

        public IPositionModel PositionModel { get; set; }

        public string PositionName => PositionModel == null ? "" : PositionModel.Name;

        public int DepartmentId => DepartmentModel?.Id ?? 0;

        public IDepartmentModel DepartmentModel { get; set; }

        public string DepartmentName => DepartmentModel == null ? "" : DepartmentModel.Name;
        
        public DateTime RegisterDate { get; set; }
        public bool IsResigned { get; set; }
        public DateTime ResignedDate { get; set; }
        public string ResignedReason { get; set; }
    }
}