using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatttern
{
    class ThirdPartyExport : IThirdPartyExport
    {
        public void Convert()
        {
            Console.WriteLine("In Thirdparty Converter");
        }
    }
}
