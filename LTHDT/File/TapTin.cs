using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.File
{
    internal class TapTin:FileSystem
    {
        public int Size { get; set; }
        public TapTin (string name, int size) : base (name)
        {
            Size = size;
        }
        public override int GetSize()
        {
            return Size;
        }
    }
}
