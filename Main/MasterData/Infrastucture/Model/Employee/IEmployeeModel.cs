using System;
using MainInfrastructure.Model.Contact;

namespace MainInfrastructure.Model.Employee
{
    internal interface IEmployeeModel : IContactModel
    {
        int PositionId { get; }
        IPositionModel PositionModel { get; set; }
        string PositionName { get; }
        int DepartmentId { get; }
        IDepartmentModel DepartmentModel { get; set; }
        string DepartmentName { get; }
        DateTime DateOfBirth { get; set; }
        DateTime RegisterDate { get; set; }
        bool IsResigned { get; set; }
        DateTime ResignedDate { get; set; }
        string ResignedReason { get; set; }
    }
}