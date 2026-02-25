using CompositePattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composite
{
    public class FolderItem : IFileSystemItem
    {

        private readonly List<IFileSystemItem> _items = [];

        private readonly string _name;

        public FolderItem(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemItem fileSystemItem)
        {
            _items.Add(fileSystemItem);
        }

        public void RemoveItem(IFileSystemItem fileSystemItem)
        {
            _items.Remove(fileSystemItem);
        }

        public void DisplayItemDepth(int depth = 0)
        {
            //Console.WriteLine(depth);
            Console.WriteLine($"{new string('*', depth)} Folder Name: {_name}");
            foreach (var item in  _items)
            {
                item.DisplayItemDepth(depth + 2);
            }
        }
    }
}
