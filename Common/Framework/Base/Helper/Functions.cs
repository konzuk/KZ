using System.Collections.Generic;
using Framework.Interfaces.Helper;
using Resource;

namespace Framework.Base.Helper
{
    public class Functions : IFunctions
    {
        public Functions()
        {
            ListFuncs = new Dictionary<string, IFunction>
            {
                {Add.Code, Add},
                {Update.Code, Update},
                {Delete.Code, Delete},
                {View.Code, View},
                {Print.Code, Print},
                {Receive.Code, Receive},
                {ViewDetail.Code, ViewDetail}
            };
        }

        public IFunction ViewDetail => new Function
        {
            Code = "ViewDetail",
            Name = translate.View,
            Image = Icons.View_Black_32
        };

        public IFunction Add => new Function
        {
            Code = "Add",
            Name = translate.Add,
            Image = Icons.Add_Black_32
        };

        public IFunction Update => new Function
        {
            Code = "Update",
            Name = translate.Update,
            Image = Icons.Edit_Black_32
        };

        public IFunction Delete => new Function
        {
            Code = "Delete",
            Name = translate.Delete,
            Image = Icons.Delete_Black_32
        };

        public IFunction View => new Function
        {
            Code = "View",
            IsHidden = true,
            Name = translate.View,
            Image = Icons.View_Black_32
        };

        public IFunction Print => new Function
        {
            Code = "Print",
            Name = translate.Print,
            Image = Icons.Print_Black_32
        };

        public IFunction Receive => new Function
        {
            Code = "Receive",
            Name = translate.Receive,
            Image = Icons.Receive_Black_32
        };

        public Dictionary<string, IFunction> ListFuncs { get; }
    }
}