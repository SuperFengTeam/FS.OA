namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_ApprovalAuthority
    {
        public Guid Id { get; set; }

        public Guid? ApprovalType { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? TaskType { get; set; }

        public bool? IsAct { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? DelFlg { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
