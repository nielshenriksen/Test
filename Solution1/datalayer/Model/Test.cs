using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datalayer
{
    public partial class Test 
    {
        public bool IsNew { get { return this.Id == 0; } }

        private bool _IsDelete = false;
        public bool IsDelete { get { return _IsDelete; } set { _IsDelete = value; } }

    }
}
