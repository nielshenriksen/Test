using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datalayer.Repository
{
    public class Controller
    {
        public TestRepository Test = new TestRepository();

        public void Save(Test obj)
        {
            if (obj.IsNew) { Test.Add(obj); }
            if (obj.IsDelete) { Test.Delete(obj); }
            if (!obj.IsNew && !obj.IsDelete) { Test.Edit(obj); }
            
            Test.Save();
        }    
    }
}



