
using HC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HC.Patient.Model.Roles
{
   public  class RoleModel : BaseModel
    {
        public Guid RoleId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RoleName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public Guid DeletedBy { get; set; }

        public DateTime DeletedDateTime { get; set; }

        public Guid ModifiedBy { get; set; }

        public DateTime ModifiedDateTime{ get; set; }

    }
}
