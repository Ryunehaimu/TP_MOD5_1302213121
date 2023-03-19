using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_1302213121
{
    internal class DataGeneric_1302213121<T>
    {
        private T data;
        public DataGeneric_1302213121(T data)
        {
            this.data = data;
        }

        public void PrintData_1302213121()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
