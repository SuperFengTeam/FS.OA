namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Approval_History
    {
        public Guid Id { get; set; }

        public Guid? ApprovalInfoId { get; set; }

        public Guid? ApprovalFlowId { get; set; }

        public Guid? TaskId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public int? Status { get; set; }

        public bool? DelFlg { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
