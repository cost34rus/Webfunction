using System.Collections;

namespace WebFunction3D_core.FunctionNew.Graph3D.Json
{
    public class Data
    {
        public Data()
        {
            cols = new ArrayList
            {
                new Column
                {
                    id = "x",
                    label = "x",
                    type = "number"
                },
                new Column
                {
                    id = "y",
                    label = "y",
                    type = "number"
                },
                new Column
                {
                    id = "value",
                    label = "value",
                    type = "number"
                }
            };
        }

        public ICollection cols { get; set; }
        public ICollection rows { get; set; } 
    }
}