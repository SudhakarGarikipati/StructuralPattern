📘 Composite Pattern
Structural Design Pattern
The Composite Pattern allows you to treat individual objects and groups of objects in a uniform way.
The key idea is simple:
Leaf objects and Composite objects share the same interface.
The client does not need to know whether it is working with a single object or a whole group.


🧠 When to Use Composite
Use the Composite Pattern when:
- You need to represent part–whole hierarchies
- You want to treat individual objects and collections uniformly
- You want to simplify client code by hiding tree traversal logic
- You want to build recursive structures (folders, menus, shapes, etc.)

🏗️ Pattern Structure
Component (IGraphic / IFileSystemItem)
│
├── Leaf (Circle, Square / FileItem)
│
└── Composite (GraphicGroup / FolderItem)
       └── Contains children of type Component


Both Leaf and Composite implement the same Component interface.

🔍 Key Concepts Demonstrated
✔ Uniformity
Both leaf and composite implement the same interface.
✔ Recursion
Composite objects call the same method on their children.
✔ Tree Structures
Perfect for hierarchical data.
✔ Client Simplicity
The client only interacts with the Component interface.

📂 Folder Structure (Recommended)

CompositePattern_FileSystem/
│
├── Components/
│     ├── IFileSystemItem.cs
│     ├── FileItem.cs
│     └── FolderItem.cs
│
└── Client/
      └── FileSystemClient.cs


📝 Summary
The Composite Pattern is one of the most elegant structural patterns.
It allows you to build recursive, hierarchical structures while keeping the client code clean and unaware of whether it is working with:
- a single object
- or a whole tree of objects
This pattern is foundational for UI frameworks, file explorers, graphics editors, and category trees.