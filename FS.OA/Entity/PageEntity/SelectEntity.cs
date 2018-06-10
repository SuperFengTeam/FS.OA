using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Entity
{
    public class SelectEntity
    {
        private object _id;
        public object id
        {
            get 
            {
                return _id.ToString();
            }
            set 
            {
                _id = value;
            }
        }
        public string text { get; set; }
    }
}
