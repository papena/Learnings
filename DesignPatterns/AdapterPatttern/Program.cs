using System;

namespace AdapterPatttern
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter cone = new Converter();
            cone.export(new ExportExcel());
            cone.export(new ThirdPartyAdapter(new ThirdPartyExport()));

        }
    }
    class Converter
    {
        public void export(IExport export)
        {
            export.Export();
        }
    }
}
