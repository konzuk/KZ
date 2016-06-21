using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Framework.Annotations;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model
{
    public class ModelBaseDecorator : ViewModelBase, IModelBase
    {
        private DateTime _fromLocalDateTime;
        private bool _isAllDate;

        private DateTime _localDateTime;

        private DateTime _localExecuteDateTime;
        private DateTime _toLocalDateTime;

        [InjectionConstructor]
        public ModelBaseDecorator(IUnityContainer container)
        {
            KZHelper = container.Resolve<IKZHelper>();
            
        }
        
        public DateTime LocalExecuteDateTime
        {
            get { return _localExecuteDateTime; }
            set
            {
                _localExecuteDateTime = value;
                RaisePropertyChanged();
            }
        }

        public DateTime UtcExecuteDateTime
        {
            get { return _localExecuteDateTime.ToUniversalTime(); }
            set
            {
                _localExecuteDateTime = value.ToLocalTime();
                RaisePropertyChanged();
            }
        }


        public DateTime UtcDateTime
        {
            get { return _localDateTime.ToUniversalTime(); }
            set
            {
                _localDateTime = value.ToLocalTime();
                RaisePropertyChanged();
            }
        }

        public virtual DateTime LocalDateTime
        {
            get { return _localDateTime; }
            set
            {
                _localDateTime = value;
                RaisePropertyChanged();
            }
        }


        public bool IsEditable { get; set; } = true;

        public bool IsDeletable { get; set; } = true;

        public bool IsHidden { get; set; }


        public IKZHelper KZHelper { get; set; }

        public DateTime FromLocalDateTime
        {
            get { return _fromLocalDateTime; }
            set
            {
                _fromLocalDateTime = value;
                RaisePropertyChanged();
            }
        }

        public DateTime ToLocalDateTime
        {
            get { return _toLocalDateTime; }
            set
            {
                _toLocalDateTime = value;
                RaisePropertyChanged();
            }
        }

        public bool IsAllDate
        {
            get { return _isAllDate; }
            set
            {
                _isAllDate = value;
                RaisePropertyChanged();
            }
        }


        public string StringFormatForDouble(double value)
        {
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var str = value.ToString(CultureInfo.InvariantCulture);
            try
            {
                var split = value.ToString(CultureInfo.InvariantCulture).Split('.');

                str = split.Length >= 2
                    ? value.ToString("N" + split[1].Length, culture)
                    : string.Format(culture, "{0:#,###0}", value);
                return str;
            }
            catch
            {
                return str;
            }
        }

        public IModelBase Clone()
        {
            return MemberwiseClone() as IModelBase;
            
        }

        public int Id { get; set; }
        private string _name;
        public string NameInLatin { get; set; }
        public string Code { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; 
                RaisePropertyChanged();
            }
        }
        
        public void RaiseAllPropertyChanged()
        {
            //base.RaisePropertyChanged();

            var pro = this.GetType().GetProperties();
            foreach (var propertyInfo in pro)
            {
                base.RaisePropertyChanged(propertyInfo.Name);
            }

        }
        public new void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            base.RaisePropertyChanged(propertyName);
        }
        

       
    }
}