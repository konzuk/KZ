
using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class FunctionModel : ModelBase, IFunctionModel
    {
        public int FunctionId { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string FunctionNameInLatin { get; set; }

    }
}
