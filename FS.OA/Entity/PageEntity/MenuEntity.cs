using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Entity
{
    public class MenuEntity
    {
        public string PageId { get; set; }

       public string PageCode { get; set; }

        public string PageName { get; set; }

        public Guid? ParentId { get; set; }

        public string PagePath { get; set; }

        public string ImageStyle { get; set; }

        public string ImagePath { get; set; }

        public string AuthorityIdList { get; set; }
          
        public int? PageLevel { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<MenuEntity> Children { get; set; }
    }
}
