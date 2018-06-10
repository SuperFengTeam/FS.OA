namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Page
    {
        public Guid Id { get; set; }

        [StringLength(500)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(500)]
        public string Path { get; set; }

        public Guid? ParentId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? Level { get; set; }

        [StringLength(50)]
        public string ImageStyle { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        public bool? DelFlg { get; set; }

        public Guid? AccId { get; set; }

        public Guid? SystemId { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
