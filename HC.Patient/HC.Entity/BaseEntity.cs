using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HC.Patient.Entity
{
    public class BaseEntity
    {

        //public Guid ID { get { return ID; } set { this.ID = Guid.NewGuid(); } }
        [DefaultValue("newid()")]
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public string IPAddress { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
