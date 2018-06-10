namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_TaskType
    {
        [Key]
        [Column("Id ")]
        public Guid Id_ { get; set; }

        public Guid? Name { get; set; }

        public bool? DelFlg { get; set; }

        public Guid? CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
