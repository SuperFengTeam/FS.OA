namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Staff
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(20)]
        public string StaffCode { get; set; }

        [StringLength(20)]
        public string StaffName { get; set; }

        [Column("StaffCategory ")]
        public int? StaffCategory_ { get; set; }

        public int? StaffType { get; set; }

        public int? StaffStatus { get; set; }

        public int? CompensationType { get; set; }

        public int? BankName { get; set; }

        [StringLength(50)]
        public string PayrollCard { get; set; }

        public int? OrganizationID { get; set; }

        public bool? Sex { get; set; }

        [StringLength(50)]
        public string BeforeName { get; set; }

        [Column("Nation ")]
        public int? Nation_ { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? NativePlace { get; set; }

        public bool? MaritalStatus { get; set; }

        public int? PoliticalStatus { get; set; }

        public int? HealthStatus { get; set; }

        public int? HighestEducation { get; set; }

        public bool? EntrySource { get; set; }

        public int? FileStorage { get; set; }

        [Column("ContactWay ")]
        public int? ContactWay_ { get; set; }

        [Column("GraduateInstitutions ")]
        [StringLength(50)]
        public string GraduateInstitutions_ { get; set; }

        public int? Major { get; set; }

        [Column("WorkTime ")]
        public DateTime? WorkTime_ { get; set; }

        public DateTime? ProfessionalWorkTime { get; set; }

        [StringLength(50)]
        public string Mailbox { get; set; }

        [Column("VocationalQualification ")]
        public int? VocationalQualification_ { get; set; }

        public int? PositionalTitles { get; set; }

        [StringLength(18)]
        public string IDCardNo { get; set; }

        [StringLength(100)]
        public string IDCardNoURL { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string PhotoURL { get; set; }

        public bool? SocialInsuranceStatus { get; set; }

        [StringLength(8)]
        public string SocialInsuranceNO { get; set; }

        [StringLength(50)]
        public string PaymentStandard { get; set; }

        public bool? InsuredLocation { get; set; }

        public bool? PayWay { get; set; }

        [Column("InsuredItems ")]
        [StringLength(50)]
        public string InsuredItems_ { get; set; }

        [Column("ProvidentFundSituation ")]
        public bool? ProvidentFundSituation_ { get; set; }

        [Column("ProvidentFundPaymentStandards ")]
        [StringLength(50)]
        public string ProvidentFundPaymentStandards_ { get; set; }

        [StringLength(12)]
        public string ProvidentFunNO { get; set; }

        public bool? DelFlg { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
