namespace FS.OA.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_ControlAuthority
    {
        public Guid Id { get; set; }

        public Guid? ControlId { get; set; }

        public Guid? RoleId { get; set; }

        [StringLength(500)]
        public string AuthorityIdList { get; set; }

        public Guid? UserId { get; set; }

        public bool? DelFlg { get; set; }

        [StringLength(20)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(20)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
