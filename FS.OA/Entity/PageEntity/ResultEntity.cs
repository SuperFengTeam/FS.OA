using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.OA.Entity
{
    [Serializable]
    public class ResultEntity
    {
        public bool ResultFlg { get; set; }

        public string Message { get; set; }

        public string ErrorName { get; set; }
    }
}
