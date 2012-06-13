using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new datalayer.Repository.Controller();
            //var t = new datalayer.Test();

            //t.Name = "test 1";

            var t = controller.Test.GetById(1);
            Console.WriteLine(t.Name);

            t.Name = "halløjsa";
//            controller.Save(t);
            controller.Test.Delete(t);
            Console.WriteLine(t.Id.ToString());

            Console.ReadKey();

        }
    }
}
