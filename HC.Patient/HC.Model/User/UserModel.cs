using HC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HC.Patient.Model.User
{
    public class UserModel : BaseModel
    {
        private const string PASSWORD_PATTERN = "(^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{10,}$)";
        public string ClientId { get; set; }
        [Required]
        public string UserName { get; set; }
       // public int UserRole { get; set; }
        public string[] UserRole { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string emailAddress { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //[RegularExpression(PASSWORD_PATTERN, ErrorMessage = "Passwords must contain at least ten characters, including number, uppercase, lowercase and special character letters.")]
        public string Password { get; set; }
        public System.Guid UserId { get; set; }
        public string Prefix { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
       // [Required]
        public string TelMainOne { get; set; }
        public string TelMainTwo { get; set; }
        public string TelMobile { get; set; }
        public string Telex { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastLoginDateTime { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? OfficeId { get; set; }
        public Nullable<System.Guid> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDateTime { get; set; }
        public string ImageType { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public Guid? EntityId { get; set; }
    }
}
