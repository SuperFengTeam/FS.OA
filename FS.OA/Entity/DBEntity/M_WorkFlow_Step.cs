namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_WorkFlow_Step
    {
        public Guid Id { get; set; }

        public Guid? WorkFlowId { get; set; }

        public Guid? TaskId { get; set; }

        public Guid? Seq { get; set; }

        public int? LoopNumber { get; set; }

        public Guid? BackId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool? DelFlg { get; set; }

        public Guid? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
