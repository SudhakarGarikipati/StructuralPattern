using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Components
{
    public class FileItem : IFileSystemItem
    {
        private readonly string _name;

        public FileItem(string name)
        {
            _name = name;
        }

        public void DisplayItemDepth(int depth = 0)
        {
            Console.WriteLine($"{new string('-', depth)} File Name: {_name}");
        }
    }
}
