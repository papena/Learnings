using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDelegate
{
   public class ListCheck
    {
        public void CheckingCollection()
        {
            List<listintclass> check = new List<listintclass>();
            check.Add(new listintclass() { MyProperty=DateTime.Now });
            check.Add(new listintclass() { MyProperty = DateTime.Now.AddDays(1) });
            check.Add(new listintclass() { MyProperty = DateTime.Now.AddDays(2) });
            check.Select(x => { x.MyProperty = DateTime.SpecifyKind(x.MyProperty, DateTimeKind.Utc); return x; }).ToList();
        }


    }
   public class listintclass
    {
        public DateTime MyProperty { get; set; }
    }
}
