namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_ApprovalFlow
    {
        public Guid Id { get; set; }

        public Guid? ApprovalId { get; set; }

        public int? Seq { get; set; }

        [StringLength(50)]
        public string NodeName { get; set; }

        public Guid? ApprovalUser { get; set; }

        public bool? IsJoint { get; set; }

        [StringLength(100)]
        public string Page { get; set; }

        public Guid? NodeId { get; set; }

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
