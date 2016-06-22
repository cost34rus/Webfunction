using System;
using System.Collections.Generic;
using WebFunction3D_core.FunctionNew.API;

namespace WebFunction3D_core.FunctionNew.Common
{
    public class Params<T>  : List<T> where T : class, IParam
    {
        public T Get(Func<T, bool> predicate)
        {
            T source1 = default(T);
            long num = 0L;
            foreach (T source2 in this)
            {
                if (predicate(source2))
                {
                    source1 = source2;
                    checked { ++num; }
                }
            }
            if (num == 0L)
                return null;
            if (num == 1L)
                return source1;
            return null;
        }
    }
}