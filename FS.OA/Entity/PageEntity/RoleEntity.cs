//-----------------------------------------------------------------------
// <copyright file="RoleEntity.cs" company="DHC">
//     Copyright (C) 2017
//     功能描述：AuthorityEntity 
//     创建标识：llf     ADD     2017/05/02
//     修改标识：
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace FS.OA.Entity
{
    public class RoleEntity : M_Role
    {
        public string GroupName { get; set; }
        public List<M_PageAuthority> Pages { get; set; }
        public Guid RoleId { get; set; }

    }
}
