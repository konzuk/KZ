using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Framework.Base.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.View;

namespace Framework.Base.Helper
{
    //[System.Diagnostics.DebuggerStepThrough]
    public class KZAsynchronousTask : IKZAsynchronousTask
    {
        private readonly TaskFactory _factory = new TaskFactory();
        private readonly HashSet<Task> _tasks = new HashSet<Task>();

        protected Action ProgressAction
            =>
                delegate
                {
                    SplashScreenManager.ShowForm(Owner as Form, typeof (WaitForm1), true, true, false,
                        ParentFormState.Locked);
                };

        protected Action EndAction => delegate
        {
            if (IsCompleteTask)
                SplashScreenManager.CloseForm(true);
        };


        protected bool IsCompleteTask => _tasks == null || _tasks.Count == 0;

        public Task<TResult> StartTask<TResult>(Func<object, TResult> dowork, Action<Task<TResult>> completeWork,
            IKZMessage message)
        {
            if (_tasks.Count == 0)
            {
                ProgressAction?.Invoke();
            }


            var task = _factory.StartNew(dowork, message);

            var completeTask = task.ContinueWith(completeWork, TaskScheduler.FromCurrentSynchronizationContext());
            completeTask.ContinueWith(EndProgess, TaskScheduler.FromCurrentSynchronizationContext());

            _tasks.Add(completeTask);

            return task;
        }
        public Task<TResult> StartTask<TResult>(Func<TResult> dowork, Action<Task<TResult>> completeWork )
        {
            if (_tasks.Count == 0)
            {
                ProgressAction?.Invoke();
            }
            
            var task = _factory.StartNew(dowork);

            var completeTask = task.ContinueWith(completeWork, TaskScheduler.FromCurrentSynchronizationContext());
            completeTask.ContinueWith(EndProgess, TaskScheduler.FromCurrentSynchronizationContext());

            _tasks.Add(completeTask);

            return task;
        }

        public void StartNormalTask(Action dowork)
        {
            if (_tasks.Count == 0)
            {
                ProgressAction?.Invoke();
            }

            var task = _factory.StartNew(dowork);

            var completeTask = task.ContinueWith(EndProgess, TaskScheduler.FromCurrentSynchronizationContext());

            _tasks.Add(completeTask);
        }

        public IViewBase Owner { get; set; }


        public void RemoveAllTask()
        {
            _tasks?.Clear();
        }

        protected void EndProgess(Task task)
        {
            if (_tasks.Contains(task)) _tasks.Remove(task);

            if (_tasks.Count == 0)
            {
                EndAction?.Invoke();
            }
        }
    }
}