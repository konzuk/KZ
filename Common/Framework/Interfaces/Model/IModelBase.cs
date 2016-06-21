using System;
using System.ComponentModel;
using Framework.Interfaces.Helper;

namespace Framework.Interfaces.Model
{
    public interface IModelBase
    {
        IKZHelper KZHelper { get; set; }
        DateTime UtcDateTime { get; set; }
        DateTime LocalDateTime { get; set; }
        DateTime LocalExecuteDateTime { get; set; }
        DateTime UtcExecuteDateTime { get; set; }
        DateTime FromLocalDateTime { get; set; }
        DateTime ToLocalDateTime { get; set; }
        bool IsAllDate { get; set; }
        bool IsEditable { get; set; }
        bool IsDeletable { get; set; }
        bool IsHidden { get; set; }

        int Id { get; set; }
        string Name { get; set; }
        string NameInLatin { get; set; }
        string Code { get; set; }
        string StringFormatForDouble(double value);
        IModelBase Clone();
    }
}