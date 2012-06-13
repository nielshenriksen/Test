using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datalayer.Interface
{
    public interface ITest : IGenericRepository<Test>
    {
        Test GetById(int id);
    }
}
