using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.File
{
    internal class ThuMuc:FileSystem
    {
        List <FileSystem> childs = new List <FileSystem> ();
        public ThuMuc (string name):base(name)
        {

        }

        public override int GetSize()
        {
            int sum =0;
            foreach (FileSystem fs in childs)
            {
                sum = sum + fs.GetSize();
            }
            return sum; 
        }

        public void AddChild (FileSystem child)
        {
            childs.Add (child);
        }
        public void RemoveChild (FileSystem child)
        {
            childs.Remove (child);
        }
    }
}
