using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.OA.Entity;

namespace FS.OA.Entity
{
    public class ApprovalAuthority: M_ApprovalAuthority
    {
        public string ApprovalTypeName { get; set; }

        public string UserName { get; set; }

        public string OrganizationName { get; set; }

        public string TaskTypeName { get; set; }
    }
}
