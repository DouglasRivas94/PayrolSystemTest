﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    internal class ExcellSerializer : IPayableSerialize
    {
        public FileStream Fs { get; set; }
        public StreamWriter Sw { get; set; }

        public ExcellSerializer()
        {
            Fs = new FileStream("Test.xls", FileMode.Create);
            Sw = new StreamWriter(Fs);
        }

        public void Dispose()
        {
            if(Sw != null)
            {
                Sw.Close();
                Sw = null;
            }
            if(Fs != null)
            {
                Fs.Close();
                Fs = null;
            }
        }
    }
}
