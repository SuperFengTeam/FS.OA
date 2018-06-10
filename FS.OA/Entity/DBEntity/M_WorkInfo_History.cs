namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_WorkInfo_History
    {
        [Key]
        [Column("Id ", Order = 0)]
        public Guid Id_ { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid WorkFlowId { get; set; }

        public Guid? TaskId { get; set; }

        public Guid? WorkStateId { get; set; }

        public Guid? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
