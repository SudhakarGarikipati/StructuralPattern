using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Components
{
    public interface IFileSystemItem
    {
        void DisplayItemDepth(int depth = 0);
    }
}
