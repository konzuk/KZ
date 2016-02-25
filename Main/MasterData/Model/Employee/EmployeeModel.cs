using System;
using Framework.Base.Model.Contact;
using Framework.Interfaces.Model.Employee;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Employee
{
    public class EmployeeModel : ContactModel, IEmployeeModel
    {
        public EmployeeModel(IUnityContainer container) : base(container)
        {
        }

        public int PositionId
        {
            get { return PositionModel == null ? 0 : PositionModel.Id; }
        }

        public IPositionModel PositionModel { get; set; }

        public string PositionName
        {
            get { return PositionModel == null ? "" : PositionModel.Name; }
        }

        public int DepartmentId
        {
            get { return DepartmentModel == null ? 0 : DepartmentModel.Id; }
        }

        public IDepartmentModel DepartmentModel { get; set; }

        public string DepartmentName
        {
            get { return DepartmentModel == null ? "" : DepartmentModel.Name; }
        }

        public DateTime DateOfBirth { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsResigned { get; set; }
        public DateTime ResignedDate { get; set; }
        public string ResignedReason { get; set; }
    }
}