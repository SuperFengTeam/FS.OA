using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Entity

{
   public class PagesEntity : M_Page, IEntityBase
    {

       public string SystemName { get; set; }

        public string ParentName { get; set; }

        public string AuthorityIdList { get; set; }

       public Guid PageAuthorityId { get; set; }

       public Guid? RoleId { get; set; }
    }
}
