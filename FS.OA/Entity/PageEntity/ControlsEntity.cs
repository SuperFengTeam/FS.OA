using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Entity
{
    public class ControlsEntity : M_Control, IEntityBase
    {
        public string SystemName { get; set; }
        public string PageName { get; set; }
        public string AuthorityId { get; set; }

    }
}
