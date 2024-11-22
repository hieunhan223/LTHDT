using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.File
{
    internal abstract class FileSystem
    {
        public string Name { get; set; }
        public FileSystem(string name)
        {
            Name = name;
        }
        public abstract int GetSize();
    }
}
