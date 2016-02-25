using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables
{
    public abstract class TableBase
    {
        
        private DateTime _createdUtcDateTime = DateTime.UtcNow;
        private DateTime _modifiedUtcDateTime = DateTime.UtcNow;
        public DateTime CreatedUtcDateTime {
            get { return _createdUtcDateTime; }
            set { _createdUtcDateTime = value; }
        }
        public DateTime ModefiedUtcDateTime {
            get { return _modifiedUtcDateTime; }
            set { _modifiedUtcDateTime = value; }
        }
        [NotMapped]
        public DateTime CreatedDateTime {
            get { return _createdUtcDateTime.ToLocalTime(); }
            set { _createdUtcDateTime = value.ToUniversalTime(); }
        }
        [NotMapped]
        public DateTime ModefiedDateTime {
            get { return _modifiedUtcDateTime.ToLocalTime() ; }
            set { _modifiedUtcDateTime = value.ToUniversalTime(); }
        }
        
        public bool IsPreventDelete { get; set; }
        public bool IsPreventEdit { get; set; }
        public bool IsHidden { get; set; }


        public virtual TableBase Clone()
        {
            return this.MemberwiseClone() as TableBase; 
        }
    }
}
