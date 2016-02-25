using System.Collections.Generic;

namespace Framework.Interfaces.Helper
{
    public interface IFunctions
    {
        IFunction Add { get; }
        IFunction Update { get; }
        IFunction Delete { get; }
        IFunction View { get; }
        IFunction Print { get; }
        IFunction Receive { get; }
        Dictionary<string, IFunction> ListFuncs { get; }
    }
}