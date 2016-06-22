using System.Collections;
using System.Collections.Generic;

namespace WebFunction3D_core.FunctionNew.Graph3D.Json
{
    public class Row
    {
        public Row()
        {
            c = new List<Value>();
        }

        public ICollection c { get; set; } 
    }
}