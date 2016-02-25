using System;
using System.Globalization;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model
{
    public class ModelBaseDecorator : NotificationObject, IModelBase
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
                RaisePropertyChanged(nameof(LocalExecuteDateTime));
            }
        }

        public DateTime UtcExecuteDateTime
        {
            get { return _localExecuteDateTime.ToUniversalTime(); }
            set
            {
                _localExecuteDateTime = value.ToLocalTime();
                RaisePropertyChanged(nameof(UtcExecuteDateTime));
            }
        }


        public DateTime UtcDateTime
        {
            get { return _localDateTime.ToUniversalTime(); }
            set
            {
                _localDateTime = value.ToLocalTime();
                RaisePropertyChanged(nameof(UtcDateTime));
            }
        }

        public virtual DateTime LocalDateTime
        {
            get { return _localDateTime; }
            set
            {
                _localDateTime = value;
                RaisePropertyChanged(nameof(LocalDateTime));
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
                RaisePropertyChanged(nameof(FromLocalDateTime));
            }
        }

        public DateTime ToLocalDateTime
        {
            get { return _toLocalDateTime; }
            set
            {
                _toLocalDateTime = value;
                RaisePropertyChanged(nameof(ToLocalDateTime));
            }
        }

        public bool IsAllDate
        {
            get { return _isAllDate; }
            set
            {
                _isAllDate = value;
                RaisePropertyChanged(nameof(IsAllDate));
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
        public string Name { get; set; }
        public string NameInLatin { get; set; }
        public string Code { get; set; }
    }
}