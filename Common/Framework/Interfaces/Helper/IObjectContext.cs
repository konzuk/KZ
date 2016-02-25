using System;
using System.Data.Entity;
using System.Drawing;

namespace Framework.Interfaces.Helper
{
    public interface IObjectContext 
    {
        bool EnableLazyLoading { get; set; }
        DateTime GetServerDate { get; }
        IDbSet<T> CreateObjectSet<T>() where T : class;
        void SaveChanges();
    }
}