using System.Collections.Generic;
using System.ComponentModel;

namespace Framework.Interfaces.App
{
    public interface IKZBindingList<T> : IBindingList, IEnumerable<T>
    {
        new T this[int index] { get; set; }

        void GenerateNo();
    }
}