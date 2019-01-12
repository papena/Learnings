using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatttern
{
    class ThirdPartyAdapter :IExport
    {
        private readonly IThirdPartyExport _export;
        public ThirdPartyAdapter(IThirdPartyExport third)
        {
            _export = third;
        }

        public void Export()
        {
            _export.Convert();
        }
    }
}
