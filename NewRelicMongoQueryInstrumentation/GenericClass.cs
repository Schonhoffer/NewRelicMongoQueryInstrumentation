using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewRelicMongoQueryInstrumentation
{
    public class GenericClass<T>
    {
        public T Method()
        {
            return default(T);
        }
    }
}