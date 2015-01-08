using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NewRelicMongoQueryInstrumentation
{
    public class Nancy : NancyModule
    {
        public Nancy()
        {
            Get["/"] = p =>
                {
                    new GenericClass<object>().Method();
                    return "Hellow world";
                };
        }
    }
}