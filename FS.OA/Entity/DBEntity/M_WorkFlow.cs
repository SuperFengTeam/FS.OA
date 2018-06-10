namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_WorkFlow
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? Type { get; set; }

        public Guid? StartTask { get; set; }

        public Guid? EndTask { get; set; }

        public int? LoopNumber { get; set; }

        public int? WorkFlowLevel { get; set; }

        public Guid? DependentFlow { get; set; }

        public Guid? SubFlow { get; set; }

        public int? State { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public Guid? Charge { get; set; }

        public Guid? ApprovalFlowID { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool? DelFlg { get; set; }

        public Guid? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
