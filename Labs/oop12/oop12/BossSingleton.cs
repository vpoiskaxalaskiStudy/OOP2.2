using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop12
{
    class BossSingleton
    {
        private static BossSingleton instance;

        private BossSingleton()
        { }

        public static BossSingleton getInstance()
        {
            if (instance == null)
                instance = new BossSingleton();
            return instance;
        }
    }
}
