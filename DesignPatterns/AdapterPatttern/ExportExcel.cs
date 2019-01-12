using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatttern
{
    class ExportExcel : IExport
    {
        public void Export()
        {
            Console.WriteLine("In Excel Exporting conversion");
        }
    }
}
