using CompositePattern.Components;
using CompositePattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Client
{
    public sealed class CompositeClient
    {
        public static void Execute()
        {
            var root = new FolderItem(".Net");

            var folder1 = new FolderItem("FrameWorks");
            var folder3 = new FolderItem("WINDOWS");
            var folder4 = new FolderItem("WEB");
            folder1.Add(folder3);
            folder1.Add(folder4);
            var fileItem = new FileItem("WPF");
            var fileItem1 = new FileItem("Win Forms");
            folder3.Add(fileItem);
            folder3.Add(fileItem1);
            var fileItem2 = new FileItem("ASP.Net Core");
            var fileItem3 = new FileItem("ASP.Net Core Web API");
            folder4.Add(fileItem2);
            folder4.Add(fileItem3);
            var folder2 = new FolderItem("Languages");

            root.Add(folder1);
            root.Add(folder2);
            root.DisplayItemDepth();

        }
    }
}
