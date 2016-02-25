using System;
using System.Threading.Tasks;
using Framework.Interfaces.View;

namespace Framework.Interfaces.Helper
{
    public interface IKZAsynchronousTask
    {
        IViewBase Owner { get; set; }

        Task<TResult> StartTask<TResult>(Func<object, TResult> dowork, Action<Task<TResult>> completeWork,
            IKZMessage message);

        void RemoveAllTask();
    }
}