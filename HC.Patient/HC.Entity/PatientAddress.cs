using HC.Common.Filters;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HC.Patient.Entity
{
    public class PatientAddress : Identifiable<int>, IHasMeta
    {
        public PatientAddress()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedBy = 1;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AddressID")]
        public override int Id { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("PatientID")]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Attr("IsMailingSame")]
        public bool? IsMailingSame { get; set; }
        [Attr("Address1")]
        [StringLength(200)]
        public string Address1 { get; set; }
        [Attr("Address2")]
        [StringLength(200)]
        public string Address2 { get; set; }
        [Attr("City")]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("StateID")]
        [ForeignKey("MasterState")]
        public int StateID { get; set; }

        [Attr("StateName")]
        [NotMapped]
        public string StateName
        {
            get
            {
                try
                {
                    if (!string.IsNullOrEmpty(MasterState.StateName))
                    {
                        return MasterState.StateName;
                    }
                    return string.Empty;
                }
                catch (Exception)
                {

                    return string.Empty;
                }
            }
            set { }
        }

        [Attr("Zip")]
        [StringLength(20)]
        public string Zip { get; set; }
        [Attr("Phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        [RequiredNumber]
        [Attr("CountryID")]        
        [ForeignKey("MasterCountry")]
        public int CountryID { get; set; }

        //[Attr("MailingAddress1")]
        //[StringLength(200)]
        //public string MailingAddress1 { get; set; }
        //[Attr("MailingAddress2")]
        //[StringLength(200)]
        //public string MailingAddress2 { get; set; }
        //[Attr("MailingCity")]
        //[StringLength(100)]
        //public string MailingCity { get; set; }
        //[Attr("MailingState")]
        //[ForeignKey("MasterState1")]
        //public int? MailingState { get; set; }
        //[Attr("MailingZip")]
        //[StringLength(20)]
        //public string MailingZip { get; set; }
        //[Attr("MailingPhone")]
        //[StringLength(20)]
        //public string MailingPhone { get; set; }
        //[Attr("MailCountry")]        
        //[ForeignKey("MasterCountry1")]
        //public int? MailCountry { get; set; }
        [Required]
        [Attr("IsActive")]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [Attr("AddressTypeID")]
        [ForeignKey("MasterAddressType")]
        public int? AddressTypeID { get; set; }
        [Attr("CreatedBy")]
        [ForeignKey("Users")]
        [Required]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Attr("UpdatedBy")]
        [ForeignKey("Users1")]
        public int? UpdatedBy { get; set; }
        [Attr("IsDeleted")]
        public bool? IsDeleted { get; set; }
        [Attr("DeletedBy")]
        [ForeignKey("Users2")]
        public int? DeletedBy { get; set; }  public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Following are the relationship tables
        /// </summary>
        [HasOne("patient")]
        public virtual Patients Patient { get; set; }
        [HasOne("masterstate")]
        public virtual MasterState MasterState { get; set; }
        [HasOne("users")]
        public virtual User Users { get; set; }
        public virtual User Users1 { get; set; }
        public virtual User Users2 { get; set; }
        public virtual MasterCountry MasterCountry { get; set; }

        [HasOne("masteraddresstype")]
        public virtual MasterType MasterAddressType { get; set; }
        public Dictionary<string, object> GetMeta(IJsonApiContext context)
        {
            return new Dictionary<string, object> {
                //{ "total-count",  context.PageManager.TotalRecords },
                { "total-pages",  context.PageManager.TotalPages },
                { "page-size",  context.PageManager.PageSize },
                { "current-page",  context.PageManager.CurrentPage },
                { "default-page-size",  context.PageManager.DefaultPageSize },
            };
        }

    }
}
