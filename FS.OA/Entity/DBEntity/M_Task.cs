namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Task
    {
        [Key]
        [Column("Id ")]
        public Guid Id_ { get; set; }

        public Guid? Name { get; set; }

        public Guid? TaskStateId { get; set; }

        public Guid? Type { get; set; }

        public DateTime? ExpStartTime { get; set; }

        public DateTime? ExpEndTime { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(20)]
        public string Charge { get; set; }

        [StringLength(20)]
        public string Executor { get; set; }

        [StringLength(20)]
        public string Complete { get; set; }

        [StringLength(20)]
        public string ApprovalUser { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public Guid? DependentTask { get; set; }

        public Guid? SubTask { get; set; }

        public bool? DelFlg { get; set; }

        public Guid? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
