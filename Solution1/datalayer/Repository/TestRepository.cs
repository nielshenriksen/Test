using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datalayer.Repository
{
    public class TestRepository : GenericRepository<ShopModel, Test>, Interface.ITest
    {
        public Test GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}
