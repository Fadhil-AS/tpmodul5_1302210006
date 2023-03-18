using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302210006
{
    internal class DataGeneric_1302210006 <T>
    {
        private T data;

        public DataGeneric_1302210006(T data) { 
            this.data = data;
        }

        public void PrintData_1302210006() {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
